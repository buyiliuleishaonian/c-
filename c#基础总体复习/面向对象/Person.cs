using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    public class Person
    {
        private int _age;
        public int Age
        {
            get {
                if (_age>100||_age<0)
                {
                    _age = 22;
                }
                return _age; }
            set { _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set {
                if (value!='男'&&value!='女')
                {
                    value = '男';
                }
                _gender = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }
        public Person(string name)
        {
            if (name!="文憔悴")
            {
                name = "文憔悴";
            }
            this.Name = name;
        }
        public void Test()
        {
            Console.WriteLine("{0}----{1}----{2}",this.Name,this.Age,this.Gender);
        }
    }
}
