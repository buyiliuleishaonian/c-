using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用户输入一个数值，大于23，则显示要结婚啦
            Console.WriteLine("请输入一个数值");
            double numder = Convert.ToDouble(Console.ReadLine());
            if (numder>=23)
            {
                Console.WriteLine("您已经到了要结婚的年纪");
                Console.ReadKey();
            }

            //如果老苏的（chinese muisc）
            //如果语文成绩大于90并且音乐成绩也大于90
            //语文成绩等于100并且音乐成绩大于70，则奖励100
            Console.WriteLine("请输入老苏的语文和音乐成绩");
            double chinese = Convert.ToDouble(Console.ReadLine());
            double muisc = Convert.ToDouble(Console.ReadLine());
            if (chinese>90&&muisc>90)
            {
                Console.WriteLine("则奖励你100块");
                Console.ReadKey();
            }
            if (chinese >= 100 && muisc > 70)
            {
                Console.WriteLine("奖励100块");
                Console.ReadKey();
            }
            //bool b=((chinese>90&&muisc>90)||(chinese>=100)&&muisc>70);
            if ((chinese>90&&muisc>90)||(chinese>=100&&muisc>70))//if(b)
            {
                Console.WriteLine("给小明奖励100块");
                Console.ReadKey();
            }

            //让用户名和密码，用户名为admin，密码mypass，则提示登入成功
            Console.WriteLine("请输入用户名\n请输入密码");
            string uresName = Console.ReadLine();
            string password = Console.ReadLine();
            if (uresName=="admin"&&password=="mypass")
            {
                Console.WriteLine("登入成功");
                Console.ReadKey();
            }
        }
    }
}
