using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Knight : Unit
    {
        public Knight() 
        {
            Knight knight = new Knight();

            knight.health = 100;
            knight.defence = 60;
        }
        public override void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
