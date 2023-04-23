using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构
{
    public struct Bianliang
    {
        
    }
    internal class Program
    {
        public struct Ganson//在结构里面，可以调用枚举，就是将数据类型改为枚举
        {
            public string _name;//使用public之后，文段，可以在整个命名空间中调用
            public Gender _gender;//字段可以存储多个值
            public int _age ;
        }
        public enum Gender
        {
            男,
            女
        }
        static void Main(string[] args)
        {

            //针对某个大学的档案系统
            //姓名，性别，年龄
            string name = "";
            char gender = ' ';
            int age = 0;
            //需要声明N个变量，对此我们选择结构，生成字段

            //声明结构文段
            Ganson jgwganson;
            jgwganson._name = "蒋国文";
            jgwganson._age = 22;
            jgwganson._gender = Gender.男;//当结构里面使用了枚举，在我们程序里面，使用结构时
            //也需要使用枚举名.（值）

            Ganson fmganson;
            fmganson._age = 22;
            fmganson._name = "傅猛";
            fmganson._gender = Gender.男;
            Console.WriteLine(fmganson._name);//单独输出结构名，不会输出结构所包含的字段
            Console.WriteLine(jgwganson._name);
            Console.ReadKey();
        }
    }
}
