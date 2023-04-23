using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 枚举和int以及string类型的转换
{
    public  enum QQsatat
        {
            online,
            offline,
            liveline,
            Qme,
        }
    public enum Name
    {
        蒋,
        彭,
        孙,
        宋
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  将枚举类型强制转换成int
            //QQsatat qqsatat = QQsatat.Qme;
            ////枚举类型可以和int类型互相转换，也就说int和枚举类型兼容
            //int number_1 = 10;
            //string sum = "";
            //number_1 =(int) qqsatat;
            //Console.WriteLine(number_1);//直接就是将枚举的值，进行转换，或者声明了，某个枚举的变量，给定值，之后可以使用变量名
            //Console.WriteLine((int)QQsatat.offline);
            //Console.WriteLine((int)QQsatat.liveline);
            //Console.WriteLine((int)QQsatat.Qme);
            //Console.WriteLine((int)QQsatat.online);
            ////枚举类型的值，是0开始的，但是也可以改变首位的值，就用首位的值开始向后变化
            //Console.ReadKey();
            #endregion


            #region  将int强制转换成枚举
            //将int类型转换成枚举类型
            //int number_1 = 3;
            //QQsatat satat = (QQsatat) number_1;//当int类型数字超过了枚举，则输出int类型的数字
            //Console.WriteLine(satat);
            //Console.ReadKey();
            #endregion


            #region  枚举转成字符串  可用convert.toQQsatat（）；
            //所有的类型都可以转成string类型,枚举类型转string需要convert
            int number = 10;
            string str = number.ToString();
            int sum = 199;
            string str_1 = Convert.ToString(sum);
            QQsatat satat = QQsatat.online;
            string str_2 = satat.ToString();
            Console.WriteLine(str);
            Console.WriteLine(sum);
            Console.WriteLine(str_2);
            Console.ReadKey();
            #endregion
            #region    将字符串类型转换成枚举类型
            //将字符串转换成枚举类型Qsatat name=enum.parse(number);
            //string number = "2";
            //QQsatat z=(QQsatat)Enum.Parse(typeof (QQsatat),number);
            //首先要使用.parse的方法
            //需要用typeof确定转换枚举的 （枚举名)
            //还需要等待转换的数据变量名
            //最后需要对应枚举名的变量，接收
            //转换的Enum.parse的前面加上（需要转成枚举的枚举名）



            //Name name = Name.蒋;
            //int number_1 = (int)name;
            //Console.WriteLine(number_1);
            //int number_2 = 3;
            //Name name_1 = (Name)number_2;
            //Console.WriteLine(name_1);
            //string number_3 = "";
            ////number_3 = name.ToString();
            //number_3 = Convert.ToString(name);
            //Console.WriteLine(number_3);
            //Name name_2 = (Name)Enum.Parse(typeof(Name),number_3);
            //Console.WriteLine(name_2);
            //Console.ReadKey();
            #endregion


            //练习
            //提示用户选择QQ的在线状态，接收用户的输入
            //最后打印出所选择的相应状态
            Console.WriteLine("请选择qq所处的状态");
            string qq = Console.ReadLine();
            //try
            //{
            //    QQsatat qqsatat = (QQsatat)Enum.Parse(typeof(QQsatat), qq);
            //    Console.WriteLine(qqsatat);
            //}
            //catch
            //{
            //    Console.WriteLine("输入错误，程序终止");
            //}
            //Console.ReadKey();
            switch (qq)
            {
                case "0":QQsatat qqsatat= (QQsatat)Enum.Parse(typeof(QQsatat),qq);
                    Console.WriteLine(qqsatat);
                    break;
                case "1": qqsatat = (QQsatat)Enum.Parse(typeof(QQsatat),qq);
                    Console.WriteLine(qqsatat);
                    break;
                case "2":qqsatat = (QQsatat)Enum.Parse(typeof(QQsatat),qq);
                    Console.WriteLine(qqsatat);
                    break;
                case "3":qqsatat = (QQsatat)Enum.Parse(typeof(QQsatat), qq);
                    Console.WriteLine(qqsatat);
                    break;
                default: Console.WriteLine("输入不正确，程序结束");
                    break;
           }
            Console.ReadKey();
        }
    }    
}
