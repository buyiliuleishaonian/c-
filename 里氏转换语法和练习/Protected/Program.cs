using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Person
    {
        protected string _name;
    }
    public class Student:Person
    {
        public void Test()
        {
            _name = "s";
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
