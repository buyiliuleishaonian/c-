using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环嵌套
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for循环的嵌套
            for (int i=0;i<10;i++)
            {
                for(int j=0;j<10;j++)
                {
                    Console.WriteLine("hello world\t{0}", i);
                }
            }
            Console.ReadKey(); 
        }
    }
}
