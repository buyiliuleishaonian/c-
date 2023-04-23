using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int max= Program.GatMax(8, 22);//调用方法，首先选择类名.方法名（[参数]），
            Console.WriteLine(max);
            Console.ReadKey();
        }
        //方法和主函数，是平级关系，建立在类里面
        /// <summary>
        /// 比较两个整数之间的大小
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>输出两个数之间最大的整数</returns>
        public static int GatMax(int n1, int n2)
        {
            return n1 >n2 ? n1 : n2;
        }
    }
}
