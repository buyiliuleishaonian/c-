using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二天复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //单行注释 //  多行注释/* */  文本注释  ///  注释文本和类
            //快捷键  ctrl+k+d 对齐程序 ctrl+k+c 注释全部  ctrl+k+u 取消注释  ctrl+b 调试程序  ctrl+F5 执行程序
            //保存 ctrl+s  撤销 ctrl+z  智能提示ctrl+j  shift+home向左边全选 shift+end向右边全选
            //region  endregoin  用来折叠程序  

            //变量  int  double  char string   decimal 
            // 首先要声明 变量  变量名要有意义   变量要是字母+_或者数字不能有特殊符号，不能跟关键字重合，
            // Came 首字母小写后面首字母大写，一般是变量的命名  
            //Pascal 标识符中 每个单词首字母  大写   多用于给类和方法命名
            
            //赋值运算符：=  
            //加号：相加，连接，两边数字：相加，两边是有一边是字符串起连接

            //算术运算符 + - * / %

            //类型转换(类型要兼容)
            //自动类型转换  小的转大的  int——double
            //强行类型转换  大的转小的 double-int     double d=22.22  int x=(int) d
            //对于表达式而言   操作数有一个是double 整个表达式转为double

            //转译符
            // \n \b \\  \" \t  @  \r\n
            // \n 表示换行
            //  \b 表示删除 在此之前的一个字
            //  \\ 表示为一个 \
            //  \"  输出英文半角
            //  \t 表示空一个tab空间
            //  \r\n 是windows  的换行
            // @ 一般放在字符串的最前面，还在英文半角"的前面 1）取消在字符串中的转译作用  2）将文本按照编辑的原格式输出
        }
    }
}
