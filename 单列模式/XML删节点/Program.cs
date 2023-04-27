using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML删节点
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //首先创建XML的对象
            XmlDocument xmldoc = new XmlDocument();
            //加载xml文档
            xmldoc.Load("练习XML.xml");

            XmlNode childnode = xmldoc.SelectSingleNode("/根节点/子节点一");

            //移除当前节点里面的所有子节点
            childnode.RemoveAll();
            //移除指定的节点
            //childnode.RemoveChild();

            xmldoc.Save("练习XML.xml");
            Console.WriteLine("删除成功");
            Console.ReadKey();
        }
    }
}
