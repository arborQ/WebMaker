﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Calculator
{
    public class OperationAdd
    {
        public float Calculate(string inputA, string inputB)
        {
            inputA = inputA.Replace('.', ',');
            inputB = inputB.Replace('.', ',');
            return float.Parse(inputA) + float.Parse(inputB);
        }
    }
}
