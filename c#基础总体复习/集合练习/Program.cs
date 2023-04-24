using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //将一个数组的奇数偶数分开，奇数在左，偶数在右
            #region
            //List<int> list = new List<int>();
            //list.AddRange(new int[] {1,2,3,4,5,6,7,8,9});
            //List<int> listJi = new List<int>();
            //List<int> listOu = new List<int>();
            //foreach (var item in list)
            //{
            //    if (item%2==0)
            //    {
            //        listOu.Add(item);
            //    }
            //    else 
            //    {
            //        listJi.Add(item);
            //    }
            //}
            //list.Clear();
            //list.AddRange(listJi);
            //list.AddRange(listOu);
            //foreach (var item in list)
            //{
            //    Console.Write(item+"\t");
            //}
            #endregion

            //从list<int>集合中找出一个集合中的最大值
            #region
            //List<int> list = new List<int>();
            //list.AddRange(new int[] { 232,43654,458765,2314,134213});
            //int max= int.MinValue;
            //foreach (var item in list)
            //{
            //    if (item>max)
            //    {
            //        max = item;
            //    }
            //}
            //Console.WriteLine(max);
            #endregion

            //将123，转成一二三
            #region
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(0,"1");
            //dic.Add(1,"2");
            //dic.Add(2,"3");
            //dic[0] = "一";
            //dic[1] = "二";
            //dic[2] = "三";
            #endregion

            //将一个字符串中每个字符出现的次数打印出来，不管大小
            //Welcome to Chinaword
            #region
            //string s = "Welcome to Chinaword";
            //首先将空删除
            //string[] s1=s.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            //string s2 = null;
            ////重新组成一个字符串
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    s2 +=s1[i];
            //}
            ////将其全部变为小写
            //s2 = s2.ToLower();
            //Dictionary<char,int> dic = new Dictionary<char,int>();
            //for (int i = 0; i < s2.Length; i++)
            //{
            //    if (dic.ContainsKey(s2[i]))
            //    {
            //        dic[s2[i]]++;
            //    }
            //    else
            //    {
            //        dic[s2[i]] = 1;
            //    }
            //}
            //foreach (KeyValuePair<char,int> item in dic)
            //{
            //    Console.WriteLine("{0}{1}",item.Key,item.Value);
            //}
            #endregion

            //j将两个集合合并到一起，将其重复的元素删除
            #region
            //ArrayList   listOne=new ArrayList();
            //ArrayList   listTwo=new ArrayList();
            //ArrayList list = new ArrayList();
            //listOne.AddRange(new string[] { "a","b","c","d","e","f"});
            //listTwo.AddRange(new string[] { "d", "e", "f", "g", "h"});
            //for (int i = 0; i <listOne.Count; i++)
            //{
            //    if (listOne[listOne.Count-i-1] == listTwo[i])
            //    {
            //        listOne.Remove(listTwo[i]);
            //    }
            //}
            //list.AddRange(listOne);
            //list.AddRange(listTwo);
            //for (int i = 0; i <list.Count; i++)
            //{
            //    Console.Write(list[i]+"\t");
            //}
            #endregion

            //
            Console.ReadKey();
        }
    }
}
