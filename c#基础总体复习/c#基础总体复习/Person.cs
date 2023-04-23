using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_基础总体复习
{
    public abstract class Person
    {
        public string Name
        {
            get;
            set;
        }
        public  abstract void Test();
        public Person(string name)
        {
            this.Name = name;
        }
    }
}
