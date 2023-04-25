using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 读取带属性的XML文件
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //如果要读取xml文档中节点中属性和属性的值
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("练习XML.xml");
            //这里需要读取子节点，并且需要读取出来属性
            XmlNodeList node = xmldoc.SelectNodes("/根节点/子节点二");
            foreach (XmlNode item in node)
            {
                //直接输出其属性的值
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Attributes["name"].Value);
                    //Console.WriteLine(item.Attributes["count"].Value);
               
            }
            Console.ReadKey();
        }
    }
}
