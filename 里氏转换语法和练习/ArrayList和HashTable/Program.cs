using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList和HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 x = new Class2();
            ArrayList list = new ArrayList();//创建集合
            //添加单个元素
            list.Add(1);
            list.Add("文憔悴");
            list.Add('男');
            list.Add(x);
            //添加多个集合
            list.AddRange(new char[] { '1', '2', '3' });
            list.AddRange(list);

            list.Remove(1);//移除指定的元素
            list.RemoveAt(2);//移除指定的下标元素
            list.RemoveRange(0, 2);//移除下标指定一定范围的元素

            //list.Sort();//排序,但是需要元素，全是同一类型的数据
            list.Reverse();//将所有的元素反转
            //Console.Clear();//清屏

            list.Insert(0, "布衣流泪少年");//在指定下标插入元素
            list.InsertRange(1, new char[] { '1', '2' });//在指定位置插入数组

            bool t = list.Contains("文憔悴");
            Console.WriteLine(t);


            for (int y = 0; y < list.Count; y++)//因为集合长度可变，所有要用count来确定长度，无法用length；
            {
                Console.WriteLine(list[y]);
            }
            Console.ReadKey(true);

            }
        }
    }
