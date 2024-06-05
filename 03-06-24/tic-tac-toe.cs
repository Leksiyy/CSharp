using System;

namespace TicTacToeGame
{
    public class TicTacToe
    {
        private static readonly Random Random = new Random();
        private char _currentPlayer = ' ';
        private char[,] _turns = new char[3, 3];
        private byte _turnsCounter = 0;

        private int[,,] _wins =
        {
            { { 0, 0 }, { 0, 1 }, { 0, 2 } },
            { { 1, 0 }, { 1, 1 }, { 1, 2 } },
            { { 2, 0 }, { 2, 1 }, { 2, 2 } },
            { { 0, 0 }, { 1, 0 }, { 2, 0 } },
            { { 0, 1 }, { 1, 1 }, { 2, 1 } },
            { { 0, 2 }, { 1, 2 }, { 2, 2 } },
            { { 0, 0 }, { 1, 1 }, { 2, 2 } },
            { { 0, 2 }, { 1, 1 }, { 2, 0 } },
        };

        private bool IsSomeoneWin()
        {
            for (int i = 0; i < _wins.GetLength(0); i++)
            {
                if (_turns[_wins[i, 0, 0], _wins[i, 0, 1]] == _currentPlayer &&
                    _turns[_wins[i, 1, 0], _wins[i, 1, 1]] == _currentPlayer &&
                    _turns[_wins[i, 2, 0], _wins[i, 2, 1]] == _currentPlayer)
                {
                    return true;
                }
            }

            return false;
        }

        private void Layout()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(_turns[i, j] == '\0' ? ' ' : _turns[i, j]);
                    if (j < 2) Console.Write("  | ");
                }

                Console.WriteLine();
                if (i < 2) Console.WriteLine("---|----|---");
            }
        }

        private void WhosTurn()
        {
            if (_currentPlayer == ' ')
            {
                _currentPlayer = Random.Next(0, 2) == 0 ? 'X' : 'O';
            }
            else
            {
                _currentPlayer = _currentPlayer == 'X' ? 'O' : 'X';
            }
        }

        private bool MakeMove(int row, int col)
        {
            if (_turns[row, col] == '\0')
            {
                _turns[row, col] = _currentPlayer;
                return true;
            }

            return false;
        }

        private bool IsBoardFull()
        {
            foreach (var cell in _turns)
            {
                if (cell == '\0') return false;
            }

            return true;
        }
        
        // 3д массивы сложно, поэтмоу тут много комментариев
        private bool TryBlockOpponent() // идея перебрать массив победных случаев и найти 2 совпадения, и если 3 ячейка свободна - перекрыть пользователю ход.
        {
            char opponent = _currentPlayer == 'X' ? 'O' : 'X'; // узнаю какой символ у пользователя

            for (int i = 0; i < _wins.GetLength(0); i++)
            {
                int count = 0; // подсчет совпадений
                int emptyRow = -1, emptyCol = -1; // переменные для того что бы на них мог походить бот

                for (int j = 0; j < 3; j++)
                {
                    int row = _wins[i, j, 0];
                    int col = _wins[i, j, 1];

                    if (_turns[row, col] == opponent) // если на припустимой победной клетке пользователь - увеличиваю счетчик совпадений
                    {
                        count++;
                    }
                    else if (_turns[row, col] == '\0') // если на "3" клетке пусто - сохраняю ее в одноименные переменные
                    {
                        emptyRow = row;
                        emptyCol = col;
                    }
                }

                if (count == 2 && emptyRow != -1 && emptyCol != -1) // проверка получилось ли найти у врага без одного хода победную комбинацию
                {
                    _turns[emptyRow, emptyCol] = _currentPlayer;
                    Console.WriteLine("Bot plays at " + emptyRow + " " + emptyCol + ".");
                    return true;
                }
            }

            return false; // если не нашел будет действовать логика случайного хода
        }


        private void BotMove()
        {
            if (TryBlockOpponent())
            {
                return;
            }
            else
            {
                int row, col;
                do
                {
                    row = Random.Next(0, 3);
                    col = Random.Next(0, 3);
                } while (_turns[row, col] != '\0');

                _turns[row, col] = _currentPlayer;
                Console.WriteLine("Bot plays at " + row + " " + col + ".");
            }
        }

        public void StartGame()
        {
            while (true)
            {
                Console.Clear();
                Layout();
                WhosTurn();
                Console.WriteLine($"Turn \"{_currentPlayer}\"");

                if (_currentPlayer == 'X')
                {
                    int row, col;
                    while (true)
                    {
                        Console.WriteLine("Enter row (0, 1, or 2): ");
                        row = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter column (0, 1, or 2): ");
                        col = int.Parse(Console.ReadLine());

                        if (MakeMove(row, col))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid move, try again.");
                        }
                    }

                    _turnsCounter++;
                }
                else
                {
                    BotMove();
                    _turnsCounter++;
                }

                if (IsSomeoneWin())
                {
                    Console.Clear();
                    Layout();
                    Console.WriteLine($"Player \"{_currentPlayer}\" wins!");
                    break;
                }
                else if (IsBoardFull())
                {
                    Console.Clear();
                    Layout();
                    Console.WriteLine("The game is a draw!");
                    break;
                }
            }
        }
    }
}
