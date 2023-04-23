using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace 序列化和反序列化
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //序列化：就是将对象转换成二进制
            //反序列：就是将二进制转成对象
            Person p = new Person("文憔悴",'男',22);
            using (FileStream fs=new FileStream(@"D:\桌面\1.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                BinaryFormatter bt = new BinaryFormatter();
                bt.Serialize(fs,p);
            }
            Console.WriteLine("序列化成功");
            Person p1 = null;
            using (FileStream fr=new FileStream(@"D:\桌面\1.txt",FileMode.OpenOrCreate,FileAccess.Read))
            {
                BinaryFormatter buffer = new BinaryFormatter();
                p1= (Person)buffer.Deserialize(fr);
            }
            Console.WriteLine(p1.Name);
            Console.ReadKey();
        }
    }
}
