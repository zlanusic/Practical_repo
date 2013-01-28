using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Storm_zadatak4_
{
    class Program
    {

        static void Main(string[] args)
        {
            List<decimal> nums = new List<decimal>();

            string command = "";
            
            while (command != "IZADI")
            {
                Console.WriteLine("GLAVNI MENU");
                Console.WriteLine("================================");
                Console.WriteLine("Odaberite jednu od opcija:");
                Console.WriteLine("********************************");
                Console.WriteLine("Dodaj broj u listu.(Unesi dodaj)");
                Console.WriteLine("Trazi broj u listi.(Unesi trazi)");
                Console.WriteLine("Izadi iz programa. (Unesi kraj)");
                Console.WriteLine("********************************");
                Console.Write(">");
                command = Console.ReadLine().ToUpper();


                switch (command)
                {
                    case "DODAJ":
                        {
                            int numSelect;

                            Console.WriteLine("Izaberite opciju:");
                            Console.WriteLine("*******************************");
                            Console.WriteLine("Izaberite jednu od opcija:\n 1 za dodavanje\n 2 za povratak u glavni menu\n");


                            while (!int.TryParse(Console.ReadLine(), out numSelect))
                            {
                                Console.WriteLine("Unesite ispravan broj opcije!");
                                Console.WriteLine("Izaberite opciju:");
                                Console.WriteLine("******************************");
                            }

                            Console.WriteLine("Izabarali ste #" + numSelect);
                            Console.WriteLine("**********************************");

                            switch (numSelect)
                            {
                                case 1:
                                    {
                                        bool go = true;
                                        decimal newElement = 0;

                                        while (go)
                                        {
                                            Console.WriteLine("\nUnesi broj u intervalu <1, 100>.\nPrilikom unosa decimalnog broja unesite zarez (,)");


                                            //ukoliko korisnik unese 'x'
                                            ConsoleKeyInfo info = Console.ReadKey();
                                            if (info.KeyChar == 'x')
                                            {
                                                Console.WriteLine("\nUnijeli ste slovo x");
                                                Console.WriteLine("\nPovratak u glavni menu");

                                                break;
                                            }

                                            //ovdje dobijem exception
                                            newElement = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                            
                                            //unos sa konzole
                                            //if (!decimal.TryParse(Console.ReadLine(), out newElement))
                                            //{
 
                                            //}
                                            //if (!int.TryParse(Console.ReadLine(), 
                                            //    NumberStyles.Float, 
                                            //    CultureInfo.CurrentCulture, 
                                            //    out newElement))
                                            //{

                                            //}

                                            //zadani interval
                                            if (newElement <= 0 || newElement > 100)
                                            {
                                                Console.WriteLine("Uneseni broj nije u intrevalu");
                                                Console.WriteLine("Ponovno unesite broj");
                                                continue;
                                            }

                                            //dodaje element u listu i sortira listu
                                            nums.Add(newElement);
                                            nums.Sort();
                                        }

                                    }
                                    break;

                                case 2:
                                    {
                                        Console.WriteLine("Povratak u glavni menu");
                                        break;
                                    }
                            }

                        }
                        break;


                    case "TRAZI":
                        {
                            bool go = true;

                            while (go)
                            {
                                Console.WriteLine("*******************************************");
                                Console.WriteLine("\nUpisite trazeni broj:");

                                //ukoliko korisnik unese 'x'
                                ConsoleKeyInfo info = Console.ReadKey();
                                if (info.KeyChar == 'x')
                                {
                                    Console.WriteLine("\nUnijeli ste slovo x");
                                    Console.WriteLine("\nPovratak u glavni menu");
                                    //go = false;

                                    break;
                                }

                                //ovdje dobijem exception
                                decimal lookUpNum = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                                if (!nums.Contains(lookUpNum))
                                {
                                    Console.WriteLine("Ne postoji u listi\n");
                                }

                                Console.WriteLine();
                                foreach (int num in nums)
                                {
                                    Console.WriteLine(num);
                                }
                                Console.WriteLine("\nIndexOf " + lookUpNum + ": {0}\n", nums.IndexOf(lookUpNum));


                            }
                            continue;
                        }
                    


                    case "KRAJ":
                        {
                            Console.WriteLine("***********************************************");
                            Console.WriteLine("Ugodan dan");
                            Environment.Exit(0);
                            Console.Clear();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Unijeli ste nepostojeci odabir!\n");
                            continue;
                        }
                }
            }
        }
    }
}
