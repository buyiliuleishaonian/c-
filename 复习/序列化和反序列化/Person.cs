using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 序列化和反序列化
{
    //将一个类用serializable标记为序列化
    //序列化之后，此类不能继承
    [Serializable]
    public class Person
    {
        string _name;
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value;}
        }
        char _gender;
        public char Gender
        { 
            get { return _gender; } 
            set {  _gender = value;} 
        }
        public Person(string name,char gender,int age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }
}
