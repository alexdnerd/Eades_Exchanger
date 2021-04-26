using System;
using System.Collections.Generic;
using System.Text;

namespace Eades_Exchanger
{
    public class Exchanger
    {

        //Quarter = Math.Round(Quarter, 2, MidpointRounding.ToEven);
        //     Quarter = Math.Floor(Quarter);

        public static double ExchangeMatherizer(string currencyChooseInput, double currencyInput, string currencyChooseOutput, double currencyOutput)
        {
            if (currencyChooseInput == "USD" && currencyChooseOutput == "GBP")
            {
                currencyOutput = currencyInput * 0.72523;
                return currencyOutput;
            }
            else if (currencyChooseInput == "USD" && currencyChooseOutput == "CAN")
            {
                currencyOutput = currencyInput * 1.25427;
                return currencyOutput;
            }
            else if (currencyChooseInput == "USD" && currencyChooseOutput == "EUR")
            {
                currencyOutput = currencyInput * 0.83572;
                return currencyOutput;
            }
            else if (currencyChooseInput == "GBP" && currencyChooseOutput == "USD")
            {
                currencyOutput = currencyInput * 1.37887;
                return currencyOutput;
            }
            else if (currencyChooseInput == "GBP" && currencyChooseOutput == "CAN")
            {
                currencyOutput = currencyInput * 1.72947;
                return currencyOutput;
            }
            else if (currencyChooseInput == "GBP" && currencyChooseOutput == "EUR")
            {
                currencyOutput = currencyInput * 1.15195;
                return currencyOutput;
            }
            else if (currencyChooseInput == "CAN" && currencyChooseOutput == "USD")
            {
                currencyOutput = currencyInput * 0.79728;
                return currencyOutput;
            }
            else if (currencyChooseInput == "CAN" && currencyChooseOutput == "GBP")
            {
                currencyOutput = currencyInput * 0.57848;
                return currencyOutput;
            }
            else if (currencyChooseInput == "CAN" && currencyChooseOutput == "EUR")
            {
                currencyOutput = currencyInput * 0.66645;
                return currencyOutput;
            }
            else if (currencyChooseInput == "EUR" && currencyChooseOutput == "USD")
            {
                currencyOutput = currencyInput * 1.19648;
                return currencyOutput;
            }
            else if (currencyChooseInput == "EUR" && currencyChooseOutput == "GBP")
            {
                currencyOutput = currencyInput * 0.86826;
                return currencyOutput;
            }
            else if (currencyChooseInput == "EUR" && currencyChooseOutput == "CAN")
            {
                currencyOutput = currencyInput * 1.50040;
                return currencyOutput;
            }



        }
    }
}
