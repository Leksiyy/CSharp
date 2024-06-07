using System;

namespace _05_06_24._1
{
    internal abstract class Money
    {
        protected int _wholeSum;
        protected int _coins;
        
        private void Normalize()
        {
            if (_coins >= 100)
            {
                _wholeSum = _coins / 100;
                _coins = _coins % 100;
            }
        }

        public Money(int whole, int coins)
        {
            _wholeSum = whole;
            _coins = coins;
            Normalize();
        }

        public void ShowMoney()
        {
            Console.WriteLine(_wholeSum + "." + _coins);
        }

        public void SetMoney(int whole, int coins)
        {
            _wholeSum = whole;
            _coins = coins;
            Normalize();
        }
    }

    class Product : Money
    {
        private string _name { get; set; }

        public Product(string name, int _whole, int _coins) : base(_whole, _coins)
        {
            _name = name;
        }

        public void DecreasePrice(int whole, int coins)
        {
            int TotalCoinsDecrease = whole * 100 + coins;
            int CurrentTotalCoins = _wholeSum * 100 + coins - TotalCoinsDecrease;

            if (CurrentTotalCoins < 0)
            {
                CurrentTotalCoins = 0;
            }
            
            _wholeSum = CurrentTotalCoins / 100;
            _coins = CurrentTotalCoins % 100;
        }
    }
}