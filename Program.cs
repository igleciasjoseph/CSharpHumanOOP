using System;

namespace HumanOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Human {

        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;

        public string HealthProp {
            get {
                return $"My Health is {Health}";
            }

            set {
                Health = 100;
            }
        }

        public void sName(string Name) {
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }

        public void AddParam(string param1, int param2, int param3, int param4, int param5){
            
        }

        public void Attack(int dmg){
            int calculation = dmg + Strength*5;
            Health -= calculation;
            Console.WriteLine($"My Health is {Health}");
        }
    }   
}
