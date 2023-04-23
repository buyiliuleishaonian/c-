using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复习回忆
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //.NET平台和.NET FrameWork框架,.NET frameword框架是.NET平台不可或缺的一部分，
            //提供一个稳定运行的平台来保证基于.NET平台开发的
            //各种应用可以正常运行

            //对于上位机而言，我们主要是基于c#开发的winform的应用，达到上位机调试
            //.net  1）可以用于桌面开发winform   2）Internet应用程序，ASP.NET
            //3）手机开发 wp8  4）Unity3D游戏开发或者虚拟现实

            //.NET的两种交互模式 1）C/S：客户机/服务器，需要在客户端下载专门的软件，应用于winform
            //2）B/S：浏览器/服务器模式，应用于Internet

            //.cs结尾是类文件  class=类
            //在文件夹里面的是.SLN解决文件  .csproj:指的是c#项目文件

            //console.writeline();输出（）里面的数据
            //console.readkey();任意键，之后再继续
            //console.readline();接收数据

            //运行程序是ctrl+F5是运行，直接F5是调试，ctrl+B是检查语法有不有问题
            //shift+ctrl+D是对齐代码，ctrl+K+C全部注释 ctrl+k+D取消注释  ctrl+J弹出智能提示

            //注释 //单行注释  /* */多行注释   /// 注释类和文件

            //数据类型  int double  string char decimal(形容钱) decimal  x=200m；
            //变量，首先要生成变量，再给变量赋值，最后使用变量
            //变量作用域，声明在它的第一个{里面直到这个}括号的结束，都是可以使用的
            //占位符，按挖坑的顺序输出，要从{0}开始
            //region  endregion 折叠代码
            //声明变量  Camel  首单词的首字母不大写，后面单词的首字母大写，命名变量
            //Pascal  所有单词的首字母都大写，用来命名类和文件

            //赋值运算符 =  将等号右边的值赋值给等号左边
            //算术运算符 / + - * %(取余)
            //+  连接，相加，在字符串中间的+ 就是连接作用

            //转译符 \n \t \b \\  \"  分别表示转行，空一个tab键的位置，删除在其前面的一个，输出一个\，输出一个英文半角的"
            //@符号：取消字符串中转译符的转移功能，将字符串原格式输出

            //类型转换 强制类型转换，自动类型转换，convert类型转换，
            // 强制/自动 都是数据类型兼容的  自动小的转大的
            // int number_1;
            // double  number_2=number_1;(自动转换)      int number_1=int(numder_2)强制转换，大的转小
            //Convert  就是不兼容的数据类型转换    int number=convert  todouble（string）（要转换的数据的变量名）
            //在强制/自动类型转换，只要表达式里面，有一个操作数为double     int x=7.0*8；x自动转换成double类型

            //二元运算符 --  ++  ，子加减1，但是在运算表达式里面，前++（--）都先加减1之后在进入运算表达式运算
            //二元运算符，高于一元运算符

            //关系运算符  <>  <=  >= !=  
            //逻辑运算符  &&  ||  ！   
            //复合赋值运算符  /=  +=  -=  *=   %=  数据运算后返回给自己

            //分支结构
            //if（）    if else（）   if - else if（）判断多条件的区域性的判断
            //if的判断 以bool类型 输出判断  
            //bool 类型  true和false

            //异常捕获
            //代码语法正确，执行报错
            //使用 str {} catch {}
            //try{}  里面写可能出现异常的代码 
            //catch{} 里面写报错之后，执行的代码

        }
    }
}
