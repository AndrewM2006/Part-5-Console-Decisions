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
            while(true)
            {
                int menuOption;
                Console.Clear();
                Console.WriteLine("Press 1 for BoB Machine, Press 2 for Parking Garage");
                if (int.TryParse(Console.ReadLine(), out menuOption))
                {
                    if (menuOption == 1)
                    {
                        BankMachine();
                    }
                    else if (menuOption == 2)
                    {
                        Parking();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public static void BankMachine()
        {
            Random generator = new Random();
            double balance = generator.Next(100, 501);
            balance += generator.NextDouble();
            int transaction;
            double changeBalance, billAmount;
            string billName;
            Console.WriteLine("Welcome to The Bank of Blorb");
            Console.WriteLine("Your Current Balance Is: " + balance.ToString("C"));
            Console.WriteLine("Enter a 1 for Deposit, 2 for Withdrawal, 3 for Bill Payment, or 4 for an Account Balance Update");
            if (int.TryParse(Console.ReadLine(), out transaction))
            {
                if (transaction == 1)
                {
                    Console.WriteLine("Enter Amount For Deposit");
                    Console.Write("$");
                    if (double.TryParse(Console.ReadLine(), out changeBalance))
                    {
                        Console.WriteLine("Validating Deposit");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("Your New Balance is " + (balance + changeBalance).ToString("C"));
                        System.Threading.Thread.Sleep(4000);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Deposit");
                        Console.WriteLine("Your New Balance is " + (balance - 0.75).ToString("C"));
                        System.Threading.Thread.Sleep(4000);
                    }
                }
                else if (transaction == 2)
                {
                    Console.WriteLine("Enter Amount For Withdrawal");
                    Console.Write("$");
                    if (double.TryParse(Console.ReadLine(), out changeBalance) && changeBalance <= (balance - 0.75))
                    {
                        Console.WriteLine("Validating Withdrawal");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("Your New Balance is " + (balance - changeBalance).ToString("C"));
                        System.Threading.Thread.Sleep(4000);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Withdrawal");
                        Console.WriteLine("Your New Balance is " + (balance - 0.75).ToString("C"));
                        System.Threading.Thread.Sleep(4000);
                    }
                }
                else if (transaction == 3)
                {
                    Console.WriteLine("Enter Name of Bill");
                    billName = Console.ReadLine();
                    billAmount = generator.Next(100, 5001);
                    billAmount += generator.NextDouble();
                    Console.WriteLine(billName + " has " + billAmount.ToString("C") + " still to pay");
                    Console.WriteLine("How much will you be paying today?");
                    Console.Write("$");
                    if (double.TryParse(Console.ReadLine(), out changeBalance) && changeBalance <= (balance - 0.75))
                    {
                        Console.WriteLine("Validating Payment");
                        System.Threading.Thread.Sleep(4000);
                        if (changeBalance < billAmount)
                        {
                            Console.WriteLine(billName + " still has " + (billAmount - changeBalance).ToString("C") + " remaining");
                        }
                        else
                        {
                            changeBalance = billAmount;
                            Console.WriteLine(billName + " is now payed in full");
                        }
                        Console.WriteLine("Your New Balance is " + (balance - changeBalance).ToString("C"));
                        System.Threading.Thread.Sleep(4000);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Payment");
                        Console.WriteLine("Your New Balance is " + (balance - 0.75).ToString("C"));
                        System.Threading.Thread.Sleep(4000);
                    }
                }
                else if (transaction == 4)
                {
                    Console.WriteLine("Your New Balance is " + (balance - 0.75).ToString("C"));
                    System.Threading.Thread.Sleep(4000);
                }
                else
                {
                    Console.WriteLine("Invalid Transaction");
                    Console.WriteLine("Your New Balance is " + (balance - 0.75).ToString("C"));
                    System.Threading.Thread.Sleep(4000);
                }
            }
            else
            {
                Console.WriteLine("Invalid Transaction");
                Console.WriteLine("Your New Balance is " + (balance - 0.75).ToString("C"));
                System.Threading.Thread.Sleep(4000);
            }
        }
        public static void Parking()
        {
            int minutes, hours=0;
            double charge;
            bool valid=false;
            Console.WriteLine("How many Minutes were you Parked?");
            while (valid == false)
            {
                if (int.TryParse(Console.ReadLine(), out minutes)&&minutes>0)
                {
                    valid = true;
                    hours = (int)Math.Ceiling((double)minutes / 60);
                }
                else
                {
                    Console.WriteLine("Enter a Valid Number");
                }
                charge = hours * 2 + 2;
                if (charge > 20)
                {
                    charge = 20;
                }
                if (hours == 1)
                {
                    Console.WriteLine($"You have been charged {charge.ToString("C")} for {hours} hour of parking");
                }
                else
                {
                    Console.WriteLine($"You have been charged {charge.ToString("C")} for {hours} hours of parking");
                }
                System.Threading.Thread.Sleep(4000);
            }
        }
        public static void Hurricane()
        {
            int hurricane;
            if (int.TryParse(Console.ReadLine(), out  hurricane))
            {

            }
            else
            {

            }
        }
    }
}
