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

        public void LoadGuestList()
        {
            StreamReader sr = new StreamReader("..\\..\\..\\..\\..\\..\\..\\..\\..\\bin\\Måledata2år");

            string readFile = sr.ReadLine();

            string[] readFileSplit = readFile.Split(";");
        }

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