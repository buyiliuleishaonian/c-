using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入第一个数字");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入第二个数字");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入运算符");
                string s = Console.ReadLine();
                Father f = Say(s, num1, num2);
                double sum = f.Test();
                Console.WriteLine(sum);
                Console.ReadKey();
            }
        }
        public static Father Say(string s, double num1,double num2)
        {
            Father f = null;
            switch (s)
            {
                case "+": f = new Jia(num1,num2);
                    break;
                case "-":f = new JianP(num1,num2);
                    break;
                case "/":f = new Chu(num1,num2);
                    break;
                case "*":f = new Chen(num1,num2);
                    break;
            }
            return f;
        }
    }
}
