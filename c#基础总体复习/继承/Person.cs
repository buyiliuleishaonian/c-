using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    public class Person
    {
        public int  Age
        { get; set; }
        public string Name
        { set; get; }
        public char Gender
        {
            get;set;
        }
        public Person(string name,char gender,int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
    }
}
