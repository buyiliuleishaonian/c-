using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建Person类的对象
           Person jiang = new Person();//相当于创建对象，必须在主函数main中创建对象
            jiang.Age= 23;
            jiang.Name = "蒋国文";//以后对于字段的赋值，不在通过对字段赋值
            //对字段相对应的属性赋值，即可。属性可以给字段的赋值和取值进行限定
            jiang.Gender = '男';
            jiang.people();//当静态方法需要调用非静态方法得时候，需要靠创建这个类得对象.方法来实现。
            Console.ReadKey();
        }
    }
}
