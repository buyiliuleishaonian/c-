using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 用out参数_写一个多类型输出的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入用户名和密码
            //写一个验证用户名和密码的方法，
            //返回给用户一个登入结果，并且要单独返回给一个登入信息
            //如果用户名错误，就要报错说是用户名错误
            //如果密码错误，返回登入结果错误之后还要 返回就是要报错说是密码错误
            //要是密码和用户名都错，返回登入结果错误之后还要，就直接报错
            Console.WriteLine("请输入用户名");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string passWord = Console.ReadLine();
            string mcgs;
            bool x;
            Name(userName, passWord,out x,out mcgs);
            Console.WriteLine("登入{0}，结果{1}",x,mcgs);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断用户输入的用户名和密码
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="passWord">密码</param>
        /// <param name="x">判断是否登入成功</param>
        /// <param name="mcgs">判断登入效果</param>
        public static void Name(string userName ,string passWord,out bool x,out string  mcgs)
        {
            x = true;
            if (userName == "admin" && passWord == "88888")
            {
                mcgs = "登入成功";
            }
            else if (userName == "admin")
            {
                mcgs = "密码错误";
                x = false;
            }
            else if (passWord == "88888")
            {
                mcgs = "用户名错误";
                x = false;
            }
            else
            {
                mcgs = "用户名和密码错误";
                x = false;
            }
        }
    }
}
