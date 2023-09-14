using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_Console_Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            double balance = generator.Next(100, 501);
            balance += generator.NextDouble();
            int transaction;
            Console.WriteLine("Simple Banking Machine");
            Console.WriteLine("Your Current Balance Is: "+ balance.ToString("C"));
            Console.WriteLine("Enter a 1 for Deposit, 2 for Withdrawal, or 3 for bill payment");
            if (int.TryParse(Console.ReadLine(), out transaction))
            {
                if (transaction == 1)
                {

                }
                else if (transaction == 2)
                {

                }
                else if (transaction == 3)
                {

                }
                else
                {
                    Console.WriteLine("Invalid Transaction");
                    Console.WriteLine("Your New Balance is " + (balance - 0.75).ToString("C"));
                }
            }
            else
            {
                Console.WriteLine("Invalid Transaction");
                Console.WriteLine("Your New Balance is " + (balance-0.75).ToString("C"));
            }

            Console.ReadLine();
        }
    }
}
