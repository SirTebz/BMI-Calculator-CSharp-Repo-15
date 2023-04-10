using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*----------------*");
            Console.WriteLine("| BMI CALCULATOR |");
            Console.WriteLine("*----------------*");
            Console.WriteLine();

            try
            {
                Console.Write("Enter your mass (kg): ");
                int iMass = int.Parse(Console.ReadLine());
                if (iMass >= 1 && iMass <= 800)
                {
                    Console.Write("Enter your length (m): ");
                    double dLength = double.Parse(Console.ReadLine());

                    if (dLength > 0 && dLength < 3)
                    {
                        double dBMI = iMass / (dLength * dLength);

                        Console.WriteLine("\nYour BMI is " + dBMI.ToString("F2") + "\n");
                    }
                    else
                    {
                        Console.WriteLine("A length was entered that does not lie within the accepted range");
                    }
                }
                else
                {
                    Console.WriteLine("A mass was entered that does not lie within the accepted range.");
                }
            }
            catch
            {
                Console.WriteLine("Invalid value entered.");
            }

            Console.Write("Press any key to exit... ");
            Console.ReadKey();

        }
    }
}
