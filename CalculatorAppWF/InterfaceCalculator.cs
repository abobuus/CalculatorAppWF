using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppWF
{
    public interface InterfaceCalculator
    {
        void Put_A(double a);

        void Clear_A();

        double Sum(double b);

        double Subtraction(double b);

        double Multiplication(double b);

        double Division(double b);

        double Sqrt();

        double Persent(double a);

        double Reverse();

        double Opposite();

        double Memory_Show();

        void Memory_Clear();

        void M_Sum(double b);

        void M_Subtraction(double b);
    }
}
