using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习13
{
    public  class Employee:Person
    {

        public string Salary
        {
            get;set;
        }
        public override void SayHI()
        {
            Console.WriteLine("这是子类的虚方法");
        }
        public Employee(string name,char gendor,int age):base(name,gendor, age)
        {
            
        }
    }
}
