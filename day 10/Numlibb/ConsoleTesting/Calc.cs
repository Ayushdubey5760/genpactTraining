using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public class Calc
    {
        public double Add(double i, double j)
        {
            return i + j;
        }

        public double Subtract(double i, double j)
        {
            return i - j;
        }

        public double Multiply(double i, double j)
        {
            return i * j;
        }

        public double Divide(double i, double j)
        {
            return i / j;
        }

        public bool IsPrime(double i)
        {
            return true;
        }
    }
}
