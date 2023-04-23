using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建一个键值对集合
            Hashtable hs = new Hashtable();
            //添加元素
            hs.Add(1,2);
            hs.Add(2,'男');
            hs.Add(3,"蒋国文");
            //也可以通过键来给hs赋值
            //当然会先判断是否存在其键，要是存在就替换其值
            //要是不存在就创建对应的键和值
            hs[1] = "布衣流泪少年";
            hs[4] = "文无敌";


            //还可以对hashtable类型的集合清屏
            hs.Clear();
            //还可以判断hashtable类型集合所包含的键和值
            if (hs.ContainsKey(1))//contains和containskey都是用来判断包换键的
                //只有containsvalue是用来判断包含值得。
            {
                
            }
            //通过键来删除对应的元素
            hs.Remove(2);
            

            //通过foreach循环来输出hashtable类型集合的键和值
            foreach (var item in hs.Keys)
            {
                Console.WriteLine("hashtable类型集合hs的键是{0}====值是{1}", item, hs[item]);
            }
            Console.ReadKey();
        }
    }
}
