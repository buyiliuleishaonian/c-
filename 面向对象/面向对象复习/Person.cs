using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象复习
{
    public class Person
    {
        //属性，字段，方法
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("{0}今年{1}岁性别{2}",this.Name,this.Age,this.Gender);//如果选择了this._age
            //则只会执行，字段的值，但是 对象在别的类中生成喝调用，字段本字段有 
        }
    }
}
