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
            //序列化和反序列化时用来传输数据的
            //序列化：是将对象转成二进制
            //反序列化：是将二进制转成对象
            Person jgw = new Person("蒋国文",'男',22);
            //传输一个数据
            using (FileStream file=new FileStream(@"D:\桌面\new.txt", FileMode.OpenOrCreate,FileAccess.Write))
            {
                //写入数据，之前因为存储为字节，写入也需要将字符转换成字节
                //现在是将对象，序列化之后写入
                //通过序列化命名空间，建立一个可序列化和反序列化的对象
                BinaryFormatter bufffer = new BinaryFormatter();
                //filestream继承与stream
                bufffer.Serialize(file,jgw);
            }
            Console.WriteLine("序列化成功");
            Console.ReadKey();

            //接收文件
            using (FileStream file1=new FileStream(@"D:\桌面\new.txt",FileMode.OpenOrCreate,FileAccess.Read))
            {
                //开始反序列化
                BinaryFormatter buffer = new BinaryFormatter();
                //需要将反序列化的结果强转为对象类型
                Person wen=(Person) buffer.Deserialize(file1);
                Console.WriteLine(wen.Name);
                Console.WriteLine(wen.Age);
                Console.WriteLine(wen.Gender);
            }
            Console.ReadKey(true);
        }
    }
}
