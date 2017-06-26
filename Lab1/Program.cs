using System;

namespace Lab1
{
    class Program
    {
        static string ynInput()
        {
            string input = "";
            bool invalid = true;
            while (invalid) {
                Console.WriteLine("Continue? (y/n): ");
                input = Console.ReadLine();
                if ((input == "y") || (input == "n"))
                {
                    invalid = false;
                }
            }
            return input;
        }

        static void Main(string[] args)
        {
            double length = 0;
            double width = 0;
            double height = 0;
            string yesNo = "y";
            bool cont = true;
            while (cont){
                Console.Write("Enter Length: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                width = double.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                height = double.Parse(Console.ReadLine());
                double area = length * width;
                double perimeter = 2 * (length + width);
                double volume = length * width * height;
                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);
                Console.WriteLine("Volume: {0}", volume);
                yesNo = ynInput();
                if (yesNo == "n")
                {
                    cont = false;
                }
            }
        }
    }
}
