using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Storm_zadatak2
{
    class Program
    {
        public void swap(ref bool x, ref bool y)
        {
            // pomocu XOR 
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;

        }

        static void Main(string[] args)
        {
            bool x = true, y = false;
            
            Program myProg = new Program();
            myProg.swap(ref x, ref y);

            Console.WriteLine("Vrijednost x = {0} i vrijednost y = {1}\n", x, y);
            Console.ReadKey();
        }
    }
}
