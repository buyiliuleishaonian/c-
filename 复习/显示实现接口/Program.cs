﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 显示实现接口
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ifly niao = new Bird();
            niao.fly();
            Console.ReadKey();
        }
    }
}
