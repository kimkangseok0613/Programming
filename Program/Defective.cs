using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Defective : Product
    {
        public Defective()
        {
            price = 0;
            menual = "This is a Defective Product";
        }
    }
}
