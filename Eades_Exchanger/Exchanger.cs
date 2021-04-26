using System;
using System.Collections.Generic;
using System.Text;

namespace Eades_Exchanger
{
    public class Exchanger
    {
        public int test;
        
        //Quarter = Math.Round(Quarter, 2, MidpointRounding.ToEven);
        //     Quarter = Math.Floor(Quarter);

        public static double ExchangeMatherizer(string currencyChooseInput, double currencyInput, string currencyChooseOutput, double currencyOutput)
        {
            if (currencyChooseInput == "USD" && currencyChooseOutput == "GBP")
            {
                currencyOutput = currencyInput * 0.72523;
                currencyOutput = Math.Round(currencyOutput, 2, MidpointRounding.ToEven);
                return currencyOutput;
            }
            else if (currencyChooseInput == "USD" && currencyChooseOutput == "CAN")
            {
                currencyOutput = currencyInput * 1.25427;
                currencyOutput = Math.Round(currencyOutput, 2, MidpointRounding.ToEven);
                return currencyOutput;
            }
            else if (currencyChooseInput == "USD" && currencyChooseOutput == "EUR")
            {
                currencyOutput = currencyInput * 0.83572;
                currencyOutput = Math.Round(currencyOutput, 2, MidpointRounding.ToEven);
                return currencyOutput;
            }
            else if (currencyChooseInput == "GBP" && currencyChooseOutput == "USD")
            {
                currencyOutput = currencyInput * 1.37887;
                currencyOutput = Math.Round(currencyOutput, 2, MidpointRounding.ToEven);
                return currencyOutput;
            }
            else if (currencyChooseInput == "GBP" && currencyChooseOutput == "CAN")
            {
                currencyOutput = currencyInput * 1.72947;
                currencyOutput = Math.Round(currencyOutput, 2, MidpointRounding.ToEven);
                return currencyOutput;
            }
            else if (currencyChooseInput == "GBP" && currencyChooseOutput == "EUR")
            {
                currencyOutput = currencyInput * 1.15195;
                currencyOutput = Math.Round(currencyOutput, 2, MidpointRounding.ToEven);
                return currencyOutput;
            }
            else if (currencyChooseInput == "CAN" && currencyChooseOutput == "USD")
            {
                currencyOutput = currencyInput * 0.79728;
                currencyOutput = Math.Round(currencyOutput, 2, MidpointRounding.ToEven);
                return currencyOutput;
            }
            else if (currencyChooseInput == "CAN" && currencyChooseOutput == "GBP")
            {
                currencyOutput = currencyInput * 0.57848;
                currencyOutput = Math.Round(currencyOutput, 2, MidpointRounding.ToEven);
                return currencyOutput;
            }
            else if (currencyChooseInput == "CAN" && currencyChooseOutput == "EUR")
            {
                currencyOutput = currencyInput * 0.66645;
                currencyOutput = Math.Round(currencyOutput, 2, MidpointRounding.ToEven);
                return currencyOutput;
            }
            else if (currencyChooseInput == "EUR" && currencyChooseOutput == "USD")
            {
                currencyOutput = currencyInput * 1.19648;
                currencyOutput = Math.Round(currencyOutput, 2, MidpointRounding.ToEven);
                return currencyOutput;
            }
            else if (currencyChooseInput == "EUR" && currencyChooseOutput == "GBP")
            {
                currencyOutput = currencyInput * 0.86826;
                currencyOutput = Math.Round(currencyOutput, 2, MidpointRounding.ToEven);
                return currencyOutput;
            }
            else if (currencyChooseInput == "EUR" && currencyChooseOutput == "CAN")
            {
                currencyOutput = currencyInput * 1.50040;
                currencyOutput = Math.Round(currencyOutput, 2, MidpointRounding.ToEven);
                return currencyOutput;
            }
            else
            {
                return currencyOutput;
            }


        }

        //public static bool ExchangeChecker(string currencyChooseInput, double currencyInput, string currencyChooseOutput, bool checker)
        //{
        //    if (currencyChooseInput != "USD", "GBP", "CAN", "EUR")
        //    {
        //        checker == "error";

        //    }
        //}




    }
}
