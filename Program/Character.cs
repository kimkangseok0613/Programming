using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Program
{
    internal class Character
    {
        private List<Weapon> weapons;
        private int currentCount;

        public Character()
        {
            currentCount = 0;
            weapons = new List<Weapon>();
        }
        public void Acquire(Weapon weapon)
        {
            weapons.Add(weapon);
        }
        public void Swap()
        {
            if(Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if(key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine();
                    Console.WriteLine("Weapon change");
                    Console.WriteLine();
                    currentCount = currentCount + 1;

                    if(weapons.Count <= currentCount)
                    {
                        currentCount = 0;
                    }
                }
            }
        }
        public void Use()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.A)
                {
                    weapons[currentCount].Attack();
                }
            }            
        }
        public void End()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Q)
                {
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                }
            }
        }
    }
}
