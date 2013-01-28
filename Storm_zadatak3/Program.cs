using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Storm_zadatak3
{

    public class Program
    {

        static void Main(string[] args)
        {
            //kontejner za stringove iz .txt datoteke
            List<string> persons = new List<string>();

            //citamo imena iz datoteke
            using(StreamReader reader = new StreamReader(
                                @"C:\Users\zlanusic\Documents\Visual Studio 2008\Projects\Storm_zadaci\Storm_zadatak3\UnsortedWords.txt"))
            {
                string line;

                //sve dok ne dode do zadnjeg stringa,tj. line == null
                while ((line = reader.ReadLine()) != null)
                    persons.Add(line);
            }

            //default sort po abecedi
            persons.Sort();

            //upisujemo imena u datoteku
            using (StreamWriter writer = new StreamWriter(
                                @"C:\Users\zlanusic\Documents\Visual Studio 2008\Projects\Storm_zadaci\Storm_zadatak3\SortedWords.txt"))
            {
                foreach (string name in persons)
                {
                    writer.WriteLine(name);
                }
            }

            foreach (string name in persons)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
