using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 0;
            double width = 0;
            string yesNo = "y";
            bool cont = true;
            while (cont){
                Console.Write("Enter Length: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                width = double.Parse(Console.ReadLine());
                double area = length * width;
                double perimeter = 2 * (length + width);
                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);
                Console.WriteLine("Continue? (y/n): ");
                yesNo = Console.ReadLine();
                if (yesNo == "n")
                {
                    cont = false;
                }
            }
        }
    }
}
