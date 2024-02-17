using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class TemperatureConverter
    {
       public void CtoF(double celsius)
        {
            double Farhenheit= (celsius * 9 / 5) + 32;
            Console.WriteLine($"Temperature in Fahrenheit: {Farhenheit}");
        }

        public void FtoC(double fahrenheit)
        {
            double Celsius= (fahrenheit -32) * 5/ 9;
            Console.WriteLine($"Temperature in Celsius: {Celsius}");
        }
    }
}
