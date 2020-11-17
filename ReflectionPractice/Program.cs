using System;

namespace ReflectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player a = new Player
            {
                Name = "Eivor",
                Class = "Assasin",
                PoisitionX = 1,
                PositionY = 1,
                IsNpc = false
            };

            Player b = new Player
            {
                Name = "Sigurd",
                Class = "King",
                PoisitionX = 1,
                PositionY = 3,
                IsNpc = true
            };

            string eqm = a.Equals(b) ? "equals to" : "not equals to";
            Console.WriteLine($"{a.Name} is {eqm} {b.Name}");
        }
    }
}
