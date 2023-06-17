using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppWF
{
    public class Calculator : InterfaceCalculator
    {
        private double a = 0;
        private double memory = 0;

        public void Put_A(double a)
        {
            this.a = a;
        }

        public void Clear_A()
        {
            a = 0;
        }

        public double Sum(double b) => a + b;

        public double Subtraction(double b) => a - b;

        public double Multiplication(double b) => a * b;

        public double Division(double b) => a / b;

        public double Sqrt() => Math.Sqrt(a);

        public double Persent(double b) => a * b / 100;
        public double Reverse() => 1 / a;

        public double Opposite() => -a;

        public double Memory_Show() => memory;

        public void Memory_Get(double a)
        {
           memory = a;
        }

        public void Memory_Clear()
        {
            memory = 0;
        }

        public void M_Sum(double b)
        {
            memory += b;
        }

        public void M_Subtraction(double b)
        {
            memory -= b;
        }
    }
}
