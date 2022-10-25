using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1SemesterConsoleApp
{
    public class StartUp
    {

        private ElectricityController elecController;

        private string startDate;

        private string endDate;

        public void Run()
        {
            bool programOpen = true;

            while (programOpen = true)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("|                                      |");
                Console.WriteLine("|                                      |");
                Console.WriteLine("|       Velkommen til din elmåler      |");
                Console.WriteLine("|                                      |");
                Console.WriteLine("|                                      |");
                Console.WriteLine("|         Tryk 1 for case1             |");
                Console.WriteLine("|         Tryk 2 for case2             |");
                Console.WriteLine("|         Tryk 3 for case3             |");
                Console.WriteLine("|                                      |");
                Console.WriteLine("----------------------------------------");


                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        StreamReader sr = new StreamReader("Måledata2år.txt");

                        List<string[]> readFile = new List<string[]>();

                        while (sr.EndOfStream == false)
                        {
                            readFile.Add(sr.ReadLine().Split(";"));
                        }

                        foreach (string[] line in readFile)
                        {
                            if (line[0].Length < 2) break;
                            Console.WriteLine("{0} {1} {2} {3}", line[0], line[1], line[2], line[3]);
                        }
                        

                        Console.ReadLine();

                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    default:
                        Console.WriteLine("Du har indtastet en ugyldig værdi, prøv igen");
                        break;


                }
            }
        }
    }
}