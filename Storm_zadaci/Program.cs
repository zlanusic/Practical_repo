using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Storm_zadaci
{
    public class Program
    {

        //zaokruzi na cijeli broj
        public int cutInt(decimal num)
        {
            decimal integral = Math.Truncate(num);
            
            return (int)integral;//cast u int tip povratne vrijednosti fje
        }

        //zaokruzi na zeljeni broj decimala
        public decimal cutFoo(decimal num, Int64 num_digits)
        {
            decimal decPlace = (decimal)Math.Pow(10.0, (double)num_digits);//10 na ? potenciju
            Int64 temp = (Int64)(decPlace * num);//bitan je tip Int64!
            decimal mainValue = temp / decPlace;

            //ostaje decimal kao povratni tip 
            return mainValue;
 
        }


        static void Main(string[] args)
        {
            Int64 precision = 2;//npr.
            decimal rndNum = 23244.4543534M;

            Program myProg = new Program();
            decimal showNumber = myProg.cutFoo(rndNum, precision);

            Console.WriteLine("Rezultat je: {0}", showNumber);
            Console.ReadKey();

        }
    }
}
