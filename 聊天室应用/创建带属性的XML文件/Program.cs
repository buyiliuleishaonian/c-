using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 创建带属性的XML文件
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建了对象
            XmlDocument doc = new XmlDocument();
            //创建xml文档的第一行
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0","utf-8",null);
            doc.AppendChild(dec);
            //创建根节点
            XmlElement objectXml = doc.CreateElement("根节点");
            //加入到xml对象当中
            doc.AppendChild(objectXml);
            //创建子节点，添加到根节点中
            XmlElement a1 = doc.CreateElement("子节点一");
            a1.InnerText = "练习xml1";
            a1.SetAttribute("name","蒋国文");
            objectXml.AppendChild(a1);

            //创建第二个子节点：
            XmlElement a2 = doc.CreateElement("子节点二");
            a2.InnerText = "练习xml2";
            a2.SetAttribute("name","文憔悴");
            objectXml.AppendChild(a2);


            //保存xml文档
            doc.Save("练习XML.xml");
            Console.WriteLine("创建成功");
            Console.ReadKey();
        }
    }
}
