using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //学习了泛型集合，list<>，
            List<int> list1 = new List<int>();
            list1.Add(1);
            //还学习了dictionary集合,
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1,"张三");
            dic.Add(2,"李四");
            dic[3] = "王五";
            foreach(KeyValuePair<int,string> kv in dic) 
            {
                Console.WriteLine("{0}==={1}",kv.Key,kv.Value);
            }
            Console.ReadKey(true);

            //学习了文件流
            //学习了file，filestream，streamreader，streawriter
            string fileread;
            using (FileStream file1 = new FileStream(@"D:\桌面\O0521.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                //首先需要字节接受
                byte[] buffer = new byte[1024*1024*5];//5MB
                //将文件内容读取出来。,从0行开始读取，读到字节长度，为止。每次只读5mb。
                int number=file1.Read(buffer,0,buffer.Length);
                //将读取的内容解码，从0行开始解码，截取实际读取的内存.
                 fileread = Encoding.UTF8.GetString(buffer,0,number);
            }//通过文件流，可以将filestream中的所有消耗的资源释放掉
            Console.WriteLine(fileread);
            Console.ReadKey();

            //文件中写入一个
            using (FileStream file2=new FileStream(@"D:\桌面\O0521.txt", FileMode.OpenOrCreate,FileAccess.Write))
            {
                //将需要写入的字符串，先编码转换成字节
                string filewrite = "孤高自傲少年郎";
                byte[] buffer=Encoding.UTF8.GetBytes(filewrite);
                file2.Write(buffer,0,buffer.Length);
                Console.WriteLine("OK");
            }
            Console.ReadKey();

            Student student = new Student();
            Teacher teacher = new Teacher();
            School school = new School();
            Student[] student1 = { student, teacher, school };
            for (int i = 0; i < student1.Length; i++)
            {
                student1[i].QiLi();
            }
            Console.ReadKey(true);
        }
    }
}
