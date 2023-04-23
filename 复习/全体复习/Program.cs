using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 全体复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 值传递和引用传递
            //值传递：是将本身复制，之后传递
            //引用传递：是将传递对象的引用复制，之后传递下去
            //接口
            //语法：public interface Iflyable
            //接口里面的方法没有方法体，可以继承多个接口，
            //继承接口的子类，必须实现接口里面的所有方法，
            //显示使用接口,就是当子类的方法和接口里面的方法重名的时候，就需要在子类里面，通过接口名来调用接口里的方法。
        //    void Ifly.fly()
        //{
        //        Console.WriteLine("显示使用此方法。");
        //}
        //当给定的子类，找不出来相同的父类，并且没有相同的特征，这样我们就写一个接口来实现多态
        //部分类（partail）
        //密封类（sealed）
        //序列化和反序列化：传输接收数据
        //序列化：是将对象转成二进制
        //反序列化：是将二进制转成对象
        //首先要用serializable来标定序列化的类,
        //之后将序列化的类，创建一个对象，通过在binaryformatter
        //来接收或者传递数据
        //简单工厂模式：
        //将用户输入来的数据，传递给父类，通过里氏转换来调用子类，
        //访问修饰符：public private  internal   protected   internal protected
        }
    }
}
