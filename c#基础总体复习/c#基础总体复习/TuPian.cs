using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace c_基础总体复习
{
    public class TuPian:Person
    {
        public override void Test()
        {
            //通过进程来打开每个文件
            ProcessStartInfo pri = new ProcessStartInfo(this.Name);
            Process test = new Process();
            test.StartInfo = pri;
            test.Start();
        }
        public TuPian(string name):base(name)
        { 
        }
    }
}
