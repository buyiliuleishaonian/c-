using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习13
{
    public  class Person
    {
        public string Name 
        { get; set; }  
        public char Gendor
        { get; set; }
        public int Age
        { get; set; }
        public Person(string name,char gendor,int age)
        {
            this.Name = name;
            this.Gendor =gendor;
            this.Age = age;
        }
        public virtual void SayHI()
        {
            Console.WriteLine("用的是多态的虚方法");
        }
    }
}
