using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    internal class Stdeurt:Person
    {
        
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public void Test()
        {
            Console.WriteLine("我叫{0}，今年{1}岁啦，我的性别是{2}，我的工作是{3}",this.Name,this.Age,this.Gender,this.Id);
        }
        public Stdeurt(string name,int age,char gender,string id) : base(name,age,gender)
        {
            this.Id = id;
        }

    }
}
