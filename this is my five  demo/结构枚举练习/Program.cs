using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构枚举练习
{
    public struct Mycolor
    {
        public int _red;
        public int _blue;
        public int _green;
    }
    public enum Gender
    {
        男,
        女
    }
    public struct People
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mycolor jgw;
            jgw._red = 255;//因为声明的是int类型的文段
            jgw._blue = 0;
            jgw._green = 0;
            Console.WriteLine(jgw._red);

            People wqc;
            wqc._name = "文憔悴";
            wqc._age = 22;
            wqc._gender = Gender.男;

            People by;
            by._name = "布衣";
            by._age = 22;
            by._gender = Gender.男;

            People gg;
            gg._name = "孤高";
            gg._age = 22;
            gg._gender = Gender.男;
            Console.WriteLine("{0}，{1}，{2}",wqc._name,wqc._age,wqc._gender);
            Console.WriteLine("{0},{1},{2}",by._name,by._age,by._gender);
            Console.ReadKey();
        }
    }
}
