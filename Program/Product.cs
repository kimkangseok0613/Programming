using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal abstract class Product : Sensor
    {
        protected int price;
        protected string menual;

        public  void Describe()
        {
            Console.WriteLine("Menual : " + menual);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("----------------------------------------");
        }
    }
}
