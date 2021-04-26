﻿using System;

namespace Eades_Exchanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Exchanger ExchangeObject = new Exchanger();
            ExchangeMonitor ExchangeMonObject = new ExchangeMonitor();
            string currencyChooseInput;
            double currencyInput;
            string currencyChooseOutput;
            double currencyOutput;
            ConsoleKeyInfo keypress;

            do
            {
                Console.WriteLine("Welcome to the Currency Exchanger! Please enter the input currency:");
                Console.WriteLine("(USD) US Dollar, (GBP) British Pound, (CAN) Canadian Dollar, (EUR) Euro");
                currencyChooseInput = Console.ReadLine();
                currencyChooseInput = currencyChooseInput.ToUpper();
                Console.WriteLine("Please enter the ammount:");
                currencyInput = double.Parse(Console.ReadLine());


                Console.Clear();
                Console.WriteLine("Please enter the output currency:");
                Console.WriteLine("(USD) US Dollar, (GBP) British Pound, (CAN) Canadian Dollar, (EUR) Euro");
                currencyChooseOutput = Console.ReadLine();
                currencyChooseOutput = currencyChooseOutput.ToUpper();

                Console.Clear();
                //currencyOutput = ExchangeObject.ExchangeMatherizer(string currencyChooseInput, double currencyInput, string currencyChooseOutput, double currencyOutput);





                
                Console.WriteLine("Would you like to make another exchange?");
                Console.WriteLine("(E)xchange Again (Q)uit:");
                keypress = Console.ReadKey();

                if (keypress.KeyChar == 'q')
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();

                }
            } while (keypress.KeyChar != 'q');
            Console.WriteLine("Thank you for exchanging with us");
        }
    }
}
