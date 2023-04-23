using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //首先展示货物
            SupperMoney ck = new SupperMoney();
            ck.Test();
            //之后客户之间的交谈
            ck.Jiaoliu();
            Console.ReadKey(true);
        }
    }
}
