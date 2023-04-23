using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace 复习
{
    public class Person
    {
        //类里面存在，字段，属性，方法，构造函数
        //当建立字段的时候，没有写修饰符，则默认为private
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private  string  _name;
        public string Name
        {
            get { return _name; }
            set { _name = value;}
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        /// <summary>
        /// 构造函数，是给创建之后的对象的属性进行初始化赋值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Person(string name,int age ,char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        //this 有两个作用，1、表示当前类的对象
        //2、在类中显示调用构造函数
        //构造函数可以重载
        public Person(string name,int age):this(name,18,'s')
        {
            
        }
        public void SayHello()
        {
            //当方法里面输出时，用this.属性名，方便区分属性和局部变量
            //string Name="文憔悴"
            Console.WriteLine("你好，我是{0}，是{1}同学，今年{2}",this.Name,this.Gender,this.Age);
        }
        public static void SayHelloTWO()
        {
            Console.WriteLine("我是静态方法");
        }
    }
}
