using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Storm_zadatak4_
{
    class Program
    {

        static void Main(string[] args)
        {
            //List<double> listOfNums = new List<double>();
            var listOfNums = new List<double>();

            string command = "";
            
            while (command != "IZADI")
            {
                Console.WriteLine("GLAVNI MENU");
                Console.WriteLine("================================");
                Console.WriteLine("Odaberite jednu od opcija:");
                Console.WriteLine("********************************");
                Console.WriteLine("Dodaj broj u listu.(Upisi dodaj)");
                Console.WriteLine("Trazi broj u listi.(Upisi trazi)");
                Console.WriteLine("Ispisi listu.      (Upisi print)");
                Console.WriteLine("Izadi iz programa. (Upisi kraj)");
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
                                        string userInput;

                                        do
                                        {
                                            Console.WriteLine("\nUnesi broj u intervalu <1, 100>.\nPrilikom unosa decimalnog broja unesite zarez (,).\nZa izlazak unesite x");

                                            //unos sa konzole
                                            userInput = Console.ReadLine();

                                            //ukoliko user unese 'x' na konzolu
                                            if (userInput.ToLower() != "x")
                                            {
                                                double newElement;
                                                if (double.TryParse(userInput, out newElement) == true)
                                                {
                                                    if (newElement < 1 || newElement > 100)
                                                    {
                                                        Console.WriteLine("\nUneseni broj:{0} nije u zadanom intervalu", newElement);
                                                        Console.WriteLine("\nPonovno unesite broj");
                                                        continue;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\nUneseni broj:{0} je u zadanom intervalu", newElement);
                                                        listOfNums.Add(newElement);
                                                        listOfNums.Sort();
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nUnesli ste neispravan format broja:{0}", newElement);
                                                }
                                                
                                            }
                                        }
                                        while (userInput.ToLower() != "x");
                                    }
                                    break;

                                case 2:
                                    {
                                        Console.WriteLine("\nPovratak u glavni menu");
                                        break;
                                    }
                            }

                        }
                        break;


                    case "TRAZI":
                        {
                                string userInput;

                                do
                                {
                                    Console.WriteLine("\n******************************\nUpisite trazeni broj:");
                                    userInput = Console.ReadLine();

                                    //ako user unese 'x'
                                    if(userInput.ToLower() != "x")
                                    {
                                        double lookUpNum;
                                        if(double.TryParse(userInput, out lookUpNum) == true)
                                        {
                                            int index;
                                            index = listOfNums.IndexOf(lookUpNum);
                                            if (index == -1)
                                            {
                                                Console.WriteLine("\nUneseni broj:{0} ne postoji u listi!\nUnesite ponovno trazeni broj", lookUpNum);
                                                continue;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nBroj:{0} se nalazi na indeksu:{1}", lookUpNum, index);
                                                continue; 
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nUneseni znak:{0} nije broj!\nUnesite ispravan unos", userInput);
                                        }
                                    }

                                }
                                while(userInput.ToLower() != "x");
                            }
                            break;



                                                     
                    


                    case "KRAJ":
                        {
                            Console.WriteLine("\n******************************");
                            Console.WriteLine("\nUgodan dan");
                            Environment.Exit(0);
                            Console.Clear();
                            break;
                        }
                        
                    case "PRINT":
                        {
                            Console.WriteLine("Vasa lista sadrzi slijedece brojeve:");
                            foreach (var nums in listOfNums)
                            {
                                Console.WriteLine("{0}", nums);
                                
                            }
                            Console.WriteLine();
                            break;

                        }


                    default:
                        {
                            Console.WriteLine("\nUnijeli ste nepostojeci odabir!");
                            continue;
                        }
                }
            }
        }
    }
}
