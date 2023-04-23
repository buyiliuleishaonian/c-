using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ____运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 10;
            //number++;number=number+1;
            //++number;//不管放在变量前，或者后面都是，加1
            //number--;
            //--number;
            //Console.WriteLine(number);
            //Console.ReadKey();

            //int number = 10;
            ////int result = 10 + number++; //输出20，表达式中++放在后面，加的就是number原值，加完之后number加1
            ////int result=10+number;
            ////number++;
            //int result = 10 + ++number;//输出21，这里是先自身加1，再参与运算
            ////number++;
            ////int result=10+number;
            //Console.WriteLine(number);//输出11
            //Console.WriteLine(result);
            //Console.ReadKey();

            //--
            //int number = 10;
            ////int result = 10 + number--;
            //int result = 10 + --number;
            //Console.WriteLine(number);
            //Console.WriteLine(result);
            //Console.ReadKey();

            int number = 10;
            int result = number++ + ++number * 2 + --number + number++;
            //              10          12             11          11
            // 
            Console.WriteLine(number);
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
