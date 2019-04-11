using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calc
    {
        public float MakeOperation(float first, float second, string op)
        {
            if (op == "+") return first + second;
            else if (op == "-") return first - second;
            else if (op == "*") return first * second;
            else if (op == "/") return first / second;
            else return second;
        }
    }
}
