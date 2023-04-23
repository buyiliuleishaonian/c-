using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_is_two__demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //本来已经学习了 
            //显示类型转换，隐式类型转换
            //怎么将string字符串转成数值int，double类型
            //string s = "2398asc";
            //Convert.ToDouble(s);//这里的to 表示转移的意思
            //string x = Console.ReadLine();//当使用转换类型后，要明确输入的是数值类型的，要不然会报错
            //Convert.ToInt64(x);
            ////Convert.ToDouble(x);
            //int f = 2333;
            //Convert.ToString(f);
            //Console.WriteLine(x);
            //Console.ReadKey();

            //Console.WriteLine("请入姓名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请入语文成绩");
            //string strChinese = Console.ReadLine();
            //Console.WriteLine("请输入数学成绩");
            //string strMath = Console.ReadLine();
            //Console.WriteLine("请输入英语成绩");
            //string strEnglish = Console.ReadLine();
            ////  如果运算字符串，首先要转换成int double
            //double chinese=Convert.ToDouble(strChinese);
            //double math=Convert.ToDouble (strMath);
            //double english=Convert.ToDouble(strEnglish);//需要声明变量来接收转换的字符串
            //Console.WriteLine("{0},你的总成绩是{1}，平均成绩是{2:0.00}",name,chinese+math+english,(chinese+math+english)/3);
            //Console.ReadKey();

            //Console.WriteLine("请输入姓名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入语文成绩");
            //string strChinese = Console.ReadLine();
            //Console.WriteLine("请输入数学成绩");
            //string strMath = Console.ReadLine();
            //Console.WriteLine("请输入英语成绩");
            //string strEnglish = Console.ReadLine();
            //double chinese = Convert.ToDouble(strChinese);
            //double math = Convert.ToDouble(strMath);
            //double english = Convert.ToDouble(strEnglish);
            //Console.WriteLine("{0},你好你的总成绩是{1}，\n平均成绩是{2:0.00}",name,chinese+math+english,(chinese+math+english)/3);
            //Console.ReadKey();

            Console.WriteLine("请输入一个数值，来求解第几周，第几天");
            int numder = int.Parse(Console.ReadLine());
            int week = numder / 7;
            int day = numder % 7;
            Console.WriteLine("是第{0}周，第{1}天",week,day);
            Console.ReadKey();

            Console.WriteLine("请输入一个数值");
            string numder_1 = Console.ReadLine();
            int numder_2 = Convert.ToInt32(numder_1);
            int weeks = numder_2 / 7;
            int days = numder_2 % 7;
            Console.WriteLine("第{0}周，第{1}天",weeks,days);
            Console.ReadKey();
        }
    }
}
