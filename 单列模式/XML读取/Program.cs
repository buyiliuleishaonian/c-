using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML读取
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //读取xml文件
            //1、创建xml文档对象
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("练习XML.xml");
            
            //获得根节点
            XmlElement rootNode =xmldoc.DocumentElement;
            //获得根节点里面所有的子节点，
            XmlNodeList nodes=rootNode.ChildNodes;
            foreach (XmlNode item in nodes)
            {
                Console.WriteLine(item.InnerText);
            }
            Console.ReadKey();
        }
    }
}
