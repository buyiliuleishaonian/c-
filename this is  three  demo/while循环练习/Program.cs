using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace while循环练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  输入人数，输入每个人成绩，求总成绩，平均值
            //int x = 0, y = 0, numberPeople = 0, fraction = 0, z = 1;//score:分数  fraction：分数
            //Console.WriteLine("请输入班级人数");
            //try//防止人数报错
            //{
            //    numberPeople = Convert.ToInt32(Console.ReadLine());

            //    //循环体：每次输入一个人的成绩，累加成绩
            //    //循环条件就是：循环次数的累加，超过班级人数
            //    Console.WriteLine("依次输入每个人成绩");
            //    try//防止输入成绩报错
            //    {
            //        while (z < numberPeople)
            //        {
            //            Console.WriteLine("输入第{0}学员成绩",z);
            //            fraction = Convert.ToInt32(Console.ReadLine());
            //            //将每一个学员成绩，累加到总成绩里面
            //            x += fraction;
            //            z++;

            //        }
            //        y = x / numberPeople;
            //        Console.WriteLine("整个班的整体成绩是{0}，平均成绩是{1}", x, y);
            //    }
            //    catch//成绩报错
            //    {
            //        Console.WriteLine("输入成绩错误，程序退出");
            //    }
            //}
            //catch//人数报错
            //{
            //    Console.WriteLine("班级输入错误，程序退出");
            //}
            //Console.ReadKey();
            #endregion

            //要求输入用户名和密码，用户名只要不是admin，密码只要不是88888
            //循环体：提示用户输入用户名和密码，接受用户名和密码，验证用户名，密码
            //循环体：用户名和密码有一个错误，就循环
            #region    循环输入用户名和密码 
            //string userName = "", passWord = "", x = "admin", y = "88888";
            //while (userName!=x||passWord!=y)
            //{
            //    Console.WriteLine("请输入用户名");//因为是字符串输入什么都不会报错
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    passWord = Console.ReadLine();

            //}
            //Console.WriteLine("登录成功");
            //Console.ReadKey();
            #endregion

            //老师问学生是否掌握问题
            //回到会，则可以放学，回到不会，则老师再讲一遍，再次问学生是否会啦
            //循环体：学生回答问题，会，就跳出，不会老师再讲一遍，再问
            //循环条件：学生是否回答正确
            #region  这个是回答不会，就一直循环
            //string paly = "";
            //while (paly != "会")
            //{
            //    Console.WriteLine("蒋国文这道题是否会了？");
            //    paly = Console.ReadLine();
            //    if (paly == "会")
            //    {
            //        Console.WriteLine("可以放学啦");
            //    }
            //    else
            //    {
            //        Console.WriteLine("老师再讲一遍");
            //    }
            //}
            //Console.ReadKey();
            #endregion

            //这次学生不会，老师讲10遍或者讲到会为止
            //循环体：回到老师问题，会跳出，不会继续循环，接着讲10遍
            //循环条件：学生回答正确/讲了10遍
            #region
            //string paly = "";
            //int number = 0;
            //while (paly != "会" && number < 10)
            //{
            //    Console.WriteLine("蒋国文这道题你会了吗？\t{0}", number);
            //    paly = Console.ReadLine();
            //    if (paly == "会")
            //    {
            //        Console.WriteLine("可以放学啦");
            //    }
            //    else if (paly != "会")
            //    {
            //        number++;//数字加1，就跳出之后再次循环
            //    }
            //    else if (number == 10)
            //    {
            //        Console.WriteLine("可以放学啦");
            //    }
            //}
            //Console.ReadKey();
            #endregion

            //06年培训了80000，每年增长25%，
            //按这个增长速度，到那一年培训学院人数将达到20万人
            //循环体：每年人数都要增长25%，
            //循环条件：每年人数累加不超过20万
            #region
            //double people = 80000;
            //int year = 2006;
            //while (people< 200000)
            //{
            //    people = people * 1.25;
            //    year++;
            //}
            //Console.WriteLine("今年是第{0}年", year);
            //Console.ReadKey();
            #endregion

            //提示用户输入yes或者y
            //要求：只能输入yes或者y，只要不是yes或者y就要求用户一直重新输入
            //循环体：输入yes或者y，只要不是就重新输入
            //循环条件：输入的不是yes或者y
            //string str = "";
            //while (str!="yes"&&str!="y")
            //{
            //    Console.WriteLine("请用户输入yes/y");
            //    str = Console.ReadLine();
            //}
            //Console.ReadKey();

            //提示用户输入用户名和密码，要求用户名等于admin密码等于88888
            //要求：只能用户名或者密码错误，就重新输入，但是最多输入三次
            //循环体：输入用户名和密码，接收用户名和密码
            //循环条件：用户名或者密码输入错误
            //string userName = "", passWord = "";
            //int number = 0;
            //while ((number<3)&&(userName!="admin"||passWord!="88888"))
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    passWord = Console.ReadLine();
            //    number++;
            //}
            //if (userName == "admin" && passWord == "88888")
            //{
            //    Console.WriteLine("用户名{0}，你好你的密码是{1}", userName, passWord);
            //}
            //else
            //{
            //    Console.WriteLine("用户名或者密码输入错误");
            //}
            //Console.ReadKey();


            //写两个循环
            //第一个循环提示用户A输入用户名，要求A的用户名不能为空，只要为空，就要求A一直重新输入
            //第二个循环提示 用户B输入用户名，要求B的用户名不能跟A1相同并且不能为空
            //只要为空，并且跟A的用户名相同，就一直提示用户B重新输入用户名

            //第一个循环体：输入用户名，接收，验证
            //第一个循环条件：用户名为空
            //第二个循环体：输入用户名B，接收，验证
            //第二个循环条件;用户名为空并且和用户名A相同
            string userName_1 = "";
            String userName_2 = "";
            while (userName_1=="")
            {
                Console.WriteLine("请输入用户名A");
                userName_1 = Console.ReadLine();
            }
            while (userName_2 == "" || userName_2 == userName_1)
            {
                Console.WriteLine("请输入用户名B");
                userName_2 = Console.ReadLine();
            }
            Console.WriteLine("用户名A{0}，用户名B{1}",userName_1,userName_2);
            Console.ReadKey();
        }
    }
}
