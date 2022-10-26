using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

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
                        List<ElectricityMeter> meterList = new List<ElectricityMeter>();

                        while (sr.EndOfStream == false)
                        {
                            readFile.Add(sr.ReadLine().Split(";"));
                        }

                        foreach (string[] line in readFile)
                        {
                            if (line[0].Length < 2) break;
                            Console.WriteLine("{0} {1} {2} {3}", line[0], line[1], line[2], line[3]);

                        }

                        foreach (string[] line in readFile)
                        {
                            if (line[0].Length < 2) break;
                            //2020-10-23 00,00
                            string format = "yyyy-MM-dd HH,mm";
                            CultureInfo provider = CultureInfo.CreateSpecificCulture("en-US");
                            meterList.Add(new ElectricityMeter(long.Parse(line[0]), DateTime.ParseExact(line[1], format, provider), DateTime.ParseExact(line[2], format, provider), double.Parse(line[3])));

                        }


                        bool confirm = false;

                        while (confirm == false)
                        {
                            Console.WriteLine("Søg efter start dato");
                            string line1Compare = Console.ReadLine();

                            int i;
                            int j;

                            for (i = 0; i < readFile.Count; i++)
                            {
                                if (line1Compare == readFile[i][1])
                                {
                                    string[] line = readFile[i];
                                    Console.WriteLine("{0} {1} {2} {3}", line[0], line[1], line[2], line[3]);
                                }

                            }
                            Console.WriteLine();
                            Console.WriteLine("Søg efter slut dato");

                            string line2Compare = Console.ReadLine();
                            for (j = 0; i < readFile.Count; j++)
                            {
                                if (line2Compare == readFile[j][2])
                                {
                                    string[] line = readFile[j];

                                    Console.WriteLine("{0} {1} {2} {3}", line[0], line[1], line[2], line[3]);
                                }

                            }
                            Console.WriteLine();

                            Console.WriteLine("Er start datoen: {0} og slut datoen: {1}?", line1Compare, line2Compare);

                            Console.WriteLine("Tryk 1 og enter for at gå videre");
                            Console.WriteLine("Tryk 2 og enter for at prøve igen");

                            string choice = Console.ReadLine();

                            if (choice == "1")
                                confirm = true;

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