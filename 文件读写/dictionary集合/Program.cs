using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //在创建，dictionary类型的集合的时候，就需要将其键和值对应的数据类型确定好
            //dictionary所对应的就是hashtable集合
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add (1,"张三");
            dic.Add(2,"李四");
            dic.Add(3,"王五");
            //在采用foreach 输出的时候，可以用keyvaluepair来替换掉var，直接可以输出键和，值
            foreach (KeyValuePair<int,string> ky in dic)
            {
                Console.WriteLine("{0}==={1}",ky.Key,ky.Value);
            }
            Console.ReadKey();
        }
    }
}
