using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型集合联系
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建一个数组，将奇数放入一个集合，将偶数放入另一个集合
            //最终将两个集合，合并，一个在左边，一个在右边
            #region
            //List<int> list1 = new List<int>();
            //List<int> list2 = new List<int>();
            //List<int> list3 = new List<int>();
            ////Dictionary<int, int> dic = new Dictionary<int, int>();
            //List<int> list4 = new List<int>();
            //list1.AddRange(new int[] { 0,1,2,3,4,5,6,7,8,9,});
            //for (int i = 0; i < list1.Count; i++)
            //{
            //    int number = (int)list1[i];
            //    if (number % 2 == 0)
            //    {
            //        list2.Add(number);
            //    }
            //    else 
            //    {
            //        list3.Add(number);
            //    }
            //}
            //int[] ou = list2.ToArray();
            //int[] ji = list3.ToArray();
            //list4.AddRange(ou);
            //list4.AddRange(ji);
            //for (int x=0;x<list4.Count;x++)
            //{
            //    Console.Write(list4[x]);
            //}
            //Console.ReadKey();
            #endregion


            //用户输入一个字符串，通过foreach循环，将字符串赋值给集合
            #region
            //Console.WriteLine("请用户随便输入一段字符串");
            //string s = Console.ReadLine();
            //List<char> str = new List<char>();
            //foreach (var item in s)
            //{
            //    str.Add(item);
            //}
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            #endregion


            //统计Welcom to china中每个字符出现的次数，不考虑大小写
            //字符------》键
            //次数------》值
            string s = "Welcom   to   China";
            s = s.ToUpper();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int x=0;x<s.Length;x++)
            {
                if (s[x]==' ')
                {
                    continue;
                }
                if (dic.ContainsKey(s[x]))
                {
                    dic[s[x]]++;
                }
                else
                {
                    dic[s[x]] = 1;
                }
            }
            foreach (KeyValuePair<char,int> item in dic) 
            {
                Console.WriteLine("字母{0}出现了{1}次", item.Key, item.Value) ;
            }
            Console.ReadKey();
        }
    }
}
