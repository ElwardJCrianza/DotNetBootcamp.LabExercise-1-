using System;

namespace CSharp.LabExercise1
{
    internal class Program
    {
        static void Number1()
        {
            bool Calculate = true;

            Console.WriteLine("Welcome to the Rectangle Area and Perimeter Calculator!\n");

            do
            {
                Console.Write("Enter length: ");
                decimal Length = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter width: ");
                decimal Width = Convert.ToDecimal(Console.ReadLine());

                //To Compute Area
                decimal Area = Length * Width;
                Console.WriteLine("Area: {0}", Area);
                //To Compute Perimeter
                decimal Perimeter = (2 * Length) + (2 * Width);
                Console.WriteLine("Perimeter: {0}", Perimeter);

                Console.Write("Continue? (y/n): ");
                string Continue = Console.ReadLine();

                if (Continue == "n")
                {
                    Calculate = false;
                    Environment.Exit(0);
                }

            }
            while (Calculate == true);
            //Main();
        }
        static void Number2()
        {
            Console.WriteLine("Welcome to the Letter Grade Calculator!\n");
            bool ConvertGrade = true;

            do
            {
                Console.Write("Enter numerical grade: ");
                byte NumGrade = Convert.ToByte(Console.ReadLine());

                if (NumGrade <= 100)
                {
                    if (NumGrade >= 88)
                    {
                        Console.WriteLine("Letter grade: A");
                    }
                    else if (NumGrade >= 80)
                    {
                        Console.WriteLine("Letter grade: B");
                    }
                    else if (NumGrade >= 67)
                    {
                        Console.WriteLine("Letter grade: C");
                    }
                    else if (NumGrade >= 60)
                    {
                        Console.WriteLine("Letter grade: D");
                    }
                    else if (NumGrade <= 59)
                    {
                        Console.WriteLine("Letter grade: F");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Enter a value between 0-100!");
                    ConvertGrade = false;
                }
                Console.Write("Continue? (y/n): ");
                string Continue = Console.ReadLine();

                if (Continue == "n")
                {
                    ConvertGrade = false;
                    Environment.Exit(0);
                }
            }
            while (ConvertGrade == true);
            //Main();
        }
        static void Number3()
        {
            Console.WriteLine("Welcome to the Rectangle Area and Perimeter Calculator!\n");
            Console.WriteLine("This program calculates how long it will take to download a file with a 56k analog modem.\n");
            bool Estimate = true;

            do
            {
                Console.Write("Enter a file size (MB): ");
                //FileSize automatically converted into KB
                int FileSize = Convert.ToInt32(Console.ReadLine()) * 1024;

                //Find total seconds to download file
                int TotalTime = Convert.ToInt32(FileSize / 5.2);

                //Find hours
                int HoursEstimate = Convert.ToInt32(TotalTime / 3600);
                //Find minutes
                int MinutesEstimate = Convert.ToInt32((TotalTime / 60) % 60);
                //Find seconds
                int SecondsEstimate = Convert.ToInt32(TotalTime % 60);

                //Render output
                Console.WriteLine($"A \"56k\" modem will take {HoursEstimate} hours {MinutesEstimate} minutes {SecondsEstimate} seconds");

                Console.Write("Continue? (y/n): ");
                string Continue = Console.ReadLine();

                if (Continue == "n")
                {
                    Estimate = false;
                    Environment.Exit(0);
                }
            }
            while (Estimate == true);
            //Main();
        }
        static void Number4()
        {
            bool Generate = true;
            Console.WriteLine("Welcome to the Square Generator!\n");

            do
            {
                Console.Write("Enter square size: ");
                int SquareSize = Convert.ToInt32(Console.ReadLine());

                //Generate Square
                for (int l = 0; l < SquareSize; l++)
                {
                    for (int i = 1; i <= SquareSize; i++)
                    {
                        //Generate Stars
                        Console.Write("*");
                        //Create new line
                        if (i == SquareSize)
                        {
                            Console.Write("\n");
                        }
                    }
                }
                Console.Write("Continue? (y/n): ");
                string Continue = Console.ReadLine();
                if (Continue == "n")
                {
                    Generate = false;
                    Environment.Exit(0);

                }
            }
            while (Generate == true);
            //Main();
        }

        static void Main()
        {
            Number1();
            Number2();
            Number3();
            Number4();

            /*Console.WriteLine("\nHello Checker! Enter the Number you want to check\n");
            Console.WriteLine("[1] Number 1\n[2] Number 2\n[3] Number 3\n[4] Number 4\n[5] Exit\n");
            Console.Write("Enter Selection: ");
            int Selection = Convert.ToInt32(Console.ReadLine());

            switch (Selection)
            {
                case 1:
                    Number1();
                    break;
                case 2:
                    Number2();
                    break;
                case 3:
                    Number3();
                    break;
                case 4:
                    Number4();
                    break;
                case 5:
                    Environment.Exit(-1);
                    break;
            }
            */
        }
    }
}
