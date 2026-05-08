
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
            currentCount = currentCount + 1;

            if(weapons.Count <= currentCount)
            {
                currentCount = 0;
            }                
        }
        public void Use()
        {            
            weapons[currentCount].Attack();
        }
        public void End()
        {            
            Console.WriteLine("Exit");
            Environment.Exit(0);
        }
    }

