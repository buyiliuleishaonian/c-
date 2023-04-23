using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的练习
{
    public class Student
    {
        //也就是现在创建一个类，里面必须存在，字段，属性，方法
        //构造函数，析构函数
        //析构函数
        ~Student()
        {

        }
        //创建构造函数
        public Student(string name,int age,char gender,int chinese,int english,int math)
        {
            this.Name= name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }
        //构造函数可以重载
        public Student(string name,char gender,int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
        //通过关键字this，在一个构造函数中，调用别的构造函数
        public Student(string name,int age,int english):this(name,22,'c',0,english,0)
        {
            
        }
        //定义一个学生类，有六个属性，姓名，年龄，性别
        //语文成绩，英语成绩，数学成绩
        //定义属性,就必须先定义字段
        //毕竟属性是用来对于字段的赋值和取值用来限定的
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private char _gender;
        public char Gender
        {
            get
            {
                if (_gender != '男' && _gender != '女')
                {
                    _gender = '男';
                }
                return _gender;
            }
            set { _gender = value; }
        }
        private int _chinese;
        public int Chinese
        {
            get
            {
                if (_chinese > 100 || _chinese < 0)
                {
                    _chinese = 0;
                }
                return _chinese;
            }
            set { _chinese = value; }
        }
        private int _math;
        public int Math
        {
            get
            {
                if (_math < 0 || _math > 100)
                {
                    _math = 0;
                }
                return _math;
            }
            set { _math = value; }
        }
        private int _english;
        public int English
        {
            get
            {
                if (_english > 100 || _english < 0)
                {
                    _english = 0;
                }
                return _english;
            }
            set { _english = value; }
        }
        private int _sum;
       public int Sum
        {
            get { return _sum; }
            set {
                value = Chinese + English + Math;
                _sum = value; }
        }
        /// <summary>
        /// 介绍自己
        /// </summary>
        public void Test()
        {
            Console.WriteLine("我是{0}，今年{1}岁，性别{2}生", this.Name,this.Age,this.Gender);
        }
        public void Test1()
        {
            Console.WriteLine("我叫{0}，这次总分考了{1}，平均分是{2}",this.Name,this.Sum,this.Sum/3);
        }
    }
}
