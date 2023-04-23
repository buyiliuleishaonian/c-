using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //程序的调试：F11逐步调试  F10逐过程调试  断点调试
            //for循环:处理已知次数的循环，已知for循环正循环和倒循环的输出
            //for循环的嵌套
            //continue关键字：停止循环，回到循环条件判断，true则，开始新的循环，false则跳出循环
            //一般配合if使用，在if的括号里面也是使for循环，回到循环条件的判断。
            //break：跳出switch case  ，还有跳出当前的一个循环，在if里面也是跳出当前循环
            //switch （变量或者关系表达式）值要和括号里面的变量数据类型一致
            /*{
                case  值：
                           代码；
                break；
            }*/
            //bool  x=int.tryparse（console.readline（），out  number）一个方法 数据类型转化
            //方法 帮我们做一件事情。需要有参数，这里是console.readline（）； number ，一个带转换的数据
            //一个是转换后接收的变量，结果是bool类型
            //convert数据类型转化
            //tryparse（）
            
            //还学了随机数
            //首先创建一个生成随机数的对象  random  name=new random（）；
            //生成随机数对象调用.next方法生成一个随机数   int  number  =  name.next（1，11）；
            //范围是左闭又右开，然后范围也是参数， number 等于接收结果的变量、

            //三元表达式：代替if-else，string name=number_1>number_2？"老王"："老蒋";
            // 结果的数据类型要和表达式2和表达式3 一致
        }
    }
}
