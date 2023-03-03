using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace binary_to_decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            bool loop = true;
            int binaryNumber = 0;
            string containedletter = "y";
            while (loop == true)
            {
                bool tryloop = true;
                Console.Write("Enter the Binary Number : ");
                while (tryloop == true)
                {
                    try
                    {
                        binaryNumber = int.Parse(Console.ReadLine());
                        tryloop = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("An error occured when entering the number, try again");
                        tryloop = true;
                    }
                }
                int decimalV = 0;
                int base1 = 1;
                while (binaryNumber > 0)
                {
                    int reminder = binaryNumber % 10;
                    binaryNumber = binaryNumber / 10;
                    decimalV += reminder * base1;
                    base1 = base1 * 2;
                }
                tryloop = true;
                Console.WriteLine($"Decimal Value : {decimalV} ");
                Console.WriteLine("Would you like to make another request? (Y/N)");
                while (tryloop == true)
                {
                    try
                    {
                        answer = Console.ReadLine();
                        if (answer.Contains(containedletter))
                        {
                            loop = true;
                            tryloop = false;    
                        }
                        else
                        {
                            loop = false;
                            tryloop = false;
                            Console.WriteLine("Exiting, press any key to continue..");
                            Console.ReadKey();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("An error occured when entering your answer, please try again");
                    }
                }
                
                
            }
            

        }
    }
}
