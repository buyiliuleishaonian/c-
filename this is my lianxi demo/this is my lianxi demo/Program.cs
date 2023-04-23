using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_is_my_lianxi_demo
{
    public enum Name
    {
        蒋,
        文,
        王
    }
    public struct People
    {
       public int _age;
       public char _gender;
       public Name _name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //写一个循环，输入一个用户名的密码和用户名
            //只要用户名不是arishan68@gmail.com
            //密码不是 jiangguowen5201314
            //则显示输入错误。
            string userName = "",passWord="";
            while (userName !="admine"||passWord!="88888")
            {
                Console.WriteLine("请输入用户名");
                userName = Console.ReadLine();
                Console.WriteLine("请输入面密码");
                passWord = Console.ReadLine();
            }
            Console.ReadKey();

            Name name_1 = Name.文;
            People people_1;
            people_1._age = 18;
            people_1._name = Name.蒋;
            int number_1 = (int)name_1;
        }
    }
}
