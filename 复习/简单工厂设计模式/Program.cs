using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂设计模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入用户想要什么电脑");
            string name = Console.ReadLine();
            Contour  dn= Test1(name);
            dn.Test();
            Console.ReadKey();
        }
        /// <summary>
        /// 简单工厂的核心，将用户的输入赋值给父类返回
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Contour Test1(string name)
        {
            Contour dn=null;
            switch (name)
            {
                case "联想":
                    dn = new Lianxiang();
                    break;
                case "苹果":
                    dn = new Mac();
                    break;
                case "华硕":
                    dn = new Huasuo();
                    break;
            }
            return dn;
        }
    }
}
