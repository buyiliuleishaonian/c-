using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举
{
    public enum Gander
    {
        男,
        女,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //声明枚举之后，和普通的变量类型
            Gander name = Gander.男;
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
