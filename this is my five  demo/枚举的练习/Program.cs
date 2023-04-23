using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举的练习
{
    public enum Name
    {
        傅,
        蒋,
        彭,
        宋,
        朱,
        陈,
        邱,
        杨,
        孙,
        魏,
    }
    public enum Month
    {
        一月,
        二月,
        三月,
        四月,
    }
    public enum Gander
    {
        男,
        女,
    }
    //public enum Jijie
    //{
    //    夏,
    //    春,
    //    秋,
    //    冬
    //}
    //public enum Qsatal
    //{
    //    online,
    //    offline,
    //    Qme,
    //    livelin,
    //}
    //public enum Name
    //{
    //    蒋,
    //    彭,
    //    孙,
    //    宋,
    //}
    internal class Program
    {

        static void Main(string[] args)
        {
            int number_1 = 1;
            Name name_1 = (Name)number_1;
            Console.WriteLine(name_1);
            Console.WriteLine("请入的你的姓");
            string name_2 = Console.ReadLine();
            switch (name_2)
            {
                case "1":
                    Name name_3 = (Name)Enum.Parse(typeof(Name), name_2);
                    Console.WriteLine(name_3);
                    break;
                case "2" :
                    name_3 = (Name)Enum.Parse(typeof(Name), name_2);
                    Console.WriteLine(name_3);
                    break;
                case "3":
                name_3 = (Name)Enum.Parse(typeof(Name), name_2);
                    Console.WriteLine(name_3);
                    break;
                default:
                    Console.WriteLine("程序输入错误");
                    break;
            }
            Console.ReadKey();
            //Jijie jijie = Jijie.夏;
            //Qsatal QQ = Qsatal.online;
            //Jijie jijie_1 = Jijie.春;
            //Qsatal qq = Qsatal.offline;
            //Name name_1 = Name.彭;
        }
    }
}
