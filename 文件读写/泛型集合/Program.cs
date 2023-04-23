using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();
            //添加元素,只能添加，在创建集合的时候，确定好的集合类型
            number.Add(1);
            number.Add(2);
            number.Add(3);
            //list和arraylist集合所用的方法 差不都
            //增加add addrange   移除remove  removeat removerange  removeall(不会使用)
            //insert insertrange插入   sort排序,reverse反转,  包含contains
            bool x=number.Contains(1);
            //number.RemoveAll();

            //可以将list集合转成数组，也可以将数组转换成list集合
            int[] nums = number.ToArray();
        }
    }
}
