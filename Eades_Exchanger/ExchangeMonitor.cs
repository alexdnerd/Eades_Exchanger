using System;
using System.Collections.Generic;
using System.Text;

namespace Eades_Exchanger
{
    class ExchangeMonitor
    {
        public int counter;
        public double TotalExchange(string currencyChooseOutput, double currencyOutput, double total)
        {
            counter++;
            if (currencyChooseOutput == "GBP")
            {
                currencyOutput = currencyOutput * 1.37887;
            }
            if (currencyChooseOutput == "CAN")
            {
                currencyOutput = currencyOutput * 0.79728;
            }
            if (currencyChooseOutput == "EUR")
            {
                currencyOutput = currencyOutput * 1.19648;
            }
            else 
            {
                currencyOutput = currencyOutput;
            }

            total = total + currencyOutput;

            total = Math.Round(total, 2, MidpointRounding.ToEven);

            return total;

        }
    }
}
