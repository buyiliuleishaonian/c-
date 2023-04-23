using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 序列化和反序列化
{
    [Serializable]
    public class Person
    {
        public string Name
        { set; get; }
        public char Gerson
        { get; set; }
        public int Age
       { get; set; }
        public Person(string name,char gerson,int age)
        {
            this.Name = name;
            this.Gerson = gerson;
            this.Age = age;
        }
    }
}
