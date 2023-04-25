using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML追加
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //首先还是需要创建xml文档对象
            XmlDocument xmldoc = new XmlDocument();
            //需要判断文件路径里面是否含有xml文件，
            //这里使用的相对路径
            XmlElement xmlroot;
            if (File.Exists("练习XML.xml"))
            {
                //加载存在的根文件
                xmldoc.Load("练习XML.xml");
                //如果含有xml文件
                  xmlroot  =xmldoc.DocumentElement;
            }
            else
            {
                //没有xml文件，就需要创建
                XmlDeclaration dec = xmldoc.CreateXmlDeclaration("1.0","utf-8",null);
                xmldoc.AppendChild(dec);
                 xmlroot = xmldoc.CreateElement("root");
                xmldoc.AppendChild(xmlroot);
            }
            //这里开始追加就和之前是一样的添加子节点
            XmlElement childnode = xmldoc.CreateElement("nodeOne");
            childnode.InnerText = "哈哈哈";
            xmlroot.AppendChild(childnode);

            //最后还需要保存到xml文档
            xmldoc.Save("练习XML.xml");
            Console.WriteLine("追加成功");
            Console.ReadKey();
        }
    }
}
