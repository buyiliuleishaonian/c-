using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    public  class Student:Person
    {
        public Student(string name,char gender,int age,int salay):base(name,gender,age)
        {
            this.Salay = salay;
        }
        public int Salay
        {
            get;
            set;
        }
    }
}
