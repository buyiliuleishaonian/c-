using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法会哭
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //方法，最重要的就是参数，和返回值类型
            //out ref params三个重要参数
            //out  out  x是指在方法内必须赋值，而且可以随着方法的结束，一起输出的值，
            //ref ref int  x就是指在方法外赋值，随着方法的结束，一起输出的值
            //params  params  int[]，一定要声明在参数列表的最后面，要不然，不起作用，而且只能一个方法只能用一个params
            //方法的重载，就是同一个方法名称，不同的参数不同，实行不同的代码。
            //参数不同。1、参数类型不同，但个数相同
            //2、个数相同，但是参数类型不同
            //方法的递归，就是方法自己调用自己不过一定要设置，一个变量或者怎么样
            //不可以让递归一直下去，设静态字段
            //public static  int  x；
        }
    }
}
