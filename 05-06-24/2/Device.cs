using System;

namespace _05_06_24._2
{
    abstract class Device
    {
        protected string name;
        protected string madeOf;
        protected int weight;

        public Device()
        {
            name = "NaN";
            madeOf = "NaN";
            weight = 0;
        }

        public Device(string name, string madeOf, int weight)
        {
            this.name = name;
            this.madeOf = madeOf;
            this.weight = weight;
        }

        abstract public void Sound();

        abstract public void Show();
        
        abstract public void Desc();
    }

    class Cattle : Device
    {
        public Cattle(string name, string madeOf, int weight) : base(name, madeOf, weight) { }
        
        public override void Sound()
        {
            Console.Out.WriteLine("\nCattle make some sounds.");
        }

        public override void Show()
        {
            Console.Out.WriteLine("\nName of this cattle is: " + name);
        }

        public override void Desc()
        {
            Console.WriteLine("\nThis cattle made of: " + madeOf + "\nWeight of this cattle: " + weight);
        }
    } 
       
    class Microvawe : Device
    {
        public Microvawe(string name, string madeOf, int weight) : base(name, madeOf, weight) { }
        
        public override void Sound()
        {
            Console.Out.WriteLine("\nMicrovawe make some sounds.");
        }

        public override void Show()
        {
            Console.Out.WriteLine("\nName of this microvawe is: " + name);
        }

        public override void Desc()
        {
            Console.WriteLine("\nThis microvawe made of: " + madeOf + "\nWeight of this microvawe: " + weight);
        }
    } 
    
    class Automobile : Device
    {
        public Automobile(string name, string madeOf, int weight) : base(name, madeOf, weight) { }
        
        public override void Sound()
        {
            Console.Out.WriteLine("\nAutomobile make some sounds.");
        }

        public override void Show()
        {
            Console.Out.WriteLine("\nName of this automobile is: " + name);
        }

        public override void Desc()
        {
            Console.WriteLine("\nThis automobile made of: " + madeOf + "\nWeight of this automobile: " + weight);
        }
    } 
    
    class SteamMelter : Device
    {
        public SteamMelter(string name, string madeOf, int weight) : base(name, madeOf, weight) { }
        
        public override void Sound()
        {
            Console.Out.WriteLine("\nSteam melter make some sounds.");
        }

        public override void Show()
        {
            Console.Out.WriteLine("\nName of this steam melter is: " + name);
        }

        public override void Desc()
        {
            Console.WriteLine("\nThis Steam melter made of: " + madeOf + "\nWeight of this Steam melter: " + weight);
        }
    } 
}