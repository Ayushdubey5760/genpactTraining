using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Console
{
    public class Calculator
    {
        public  double Add(int i, int j)
        {
            return i + j;
        }
        public double Subtract(int i, int j)
        {
            return i - j;
        }

        public double Multiply(int i, int j)
        {
            return i * j;
        }

        public double Divide(int i, int j)
        {
            return i / j;
        }

        public bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Sqrt(number); i++) 
            {
                if(number % i ==0)
                    return false;
            }
            return true;
        }


    }
}
