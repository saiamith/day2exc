﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacedemo
{
    interface INumberoperations
    {
        int Add(int number1, int number2);
        int Subtract(int number1, int number2);
        bool Compare(int number1, int number2);
    }
}
