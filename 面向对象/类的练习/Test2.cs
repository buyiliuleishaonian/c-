using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的练习
{
    public static  class Test2
    {
        private static int _age;
        public static int Age
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
        private static string _name;
        public static string Naem
        {
            get { return _name; }
            set { _name = value; }
        }
        private static char _gender;
        public static char Gender
        {
            get
            {
                if (_gender != '男' || _gender != '女')
                {
                    _gender = '男';
                }
                return _gender;
            }
            set { _gender = value; }
        }
        private static  int _chinese;
        public static int Chinese
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
        private static int _math;
        public static int Math
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
        private static int _english;
        public static int English
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
        private static int _sum;
        public static int Sum
        {
            get { return _sum; }
            set
            {
                _sum = value;
            }
        }
        /// <summary>
        /// 介绍自己
        /// </summary>
        public static void Test()
        {
            Console.WriteLine("我是{0}，今年{1}岁，性别{2}生",Naem, Age, Gender);
        }
        public static void Test1()
        {
            Console.WriteLine("我叫{0}，这次总分考了{1}，平均分是{2}", Naem, Sum, Sum / 3);
        }
    }
}
