using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的递归
{
    internal class Program
    {
        public static  int x;
        public int y=0;
        static void Main(string[] args)
        {
            Test();
            Console.ReadKey();
        }
        public static void Test()//递归几次，return出来的时候，就需要返回几次再出来。
            //对于方法里面的变量，来限制递归的话，最好用静态字段
            //当时设置类之下的变量时，
            //public static  int x;同一个类调用x不要声明Progarm（类名）
            //public int x;调用的时候就需要声明类名。
        {
            Console.WriteLine("文憔悴最帅");
            Console.WriteLine("文憔悴最帅");
            x++;
            
            if (x >= 10)
            {
                return;
            }
            Test();
        }
    }
}
