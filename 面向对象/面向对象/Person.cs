using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    internal class Person
    {
       private int _age;//字段,不是静态字段,当用上了 private 就只能在声明的类中调用字段
        public int Age//在属性中对于字段的取值和赋值进行设定，也就是在get和set方法中，进行设定
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
        //属性
        public string Name//属性就是对字段，进行保护，限定字段的赋值和取值
        {
            //当输出属性的值的时候，调用get方法
            get { return _name; }//输出值
            //当给属性赋值的时候，首先执行set方法
            set { _name = value; }//设定值，value相当属性接受值得参数表
            //在set这个方法中参数列表名为 value
        }
        private string _name;
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        //属性
        public void people()
        {
            Console.WriteLine("{0}今年{1}岁了性别{2}生活一切正常", this.Name, this.Age, this.Gender);
            //对于输出也现需要是属性的值
        }
    }
}
