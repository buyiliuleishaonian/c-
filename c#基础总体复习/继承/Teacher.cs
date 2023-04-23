using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    public  class Teacher:Person
    {
        public string English
        {
            get;set;
        }
        public Teacher(string name,string english,char gender,int age):base(name,gender,age)
        {
            this.English = english;
        }
    }
}
