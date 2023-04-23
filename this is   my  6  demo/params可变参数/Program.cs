using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params可变参数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //求一个数组中的最大值
            int mam=GetMax(11,233,444,455);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断一个数组的最大值
        /// </summary>
        /// <param name="x">数组</param>
        /// <returns>输出最大值</returns>
        public static int GetMax(params int[] x )
        {
            int max = 0;
            for (int y=0;y<x.Length;y++)
            {
                if (max < x[y])
                {
                    max = x[y];
                }
            }
            return max;
        }
    }
}
