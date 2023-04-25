using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML文档
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //通过代码来创建XML文档
            //1、引用命名空间
            //2、创建XML文档对象（通过对象来达到读写）
            XmlDocument doc = new XmlDocument();
            //3、创建第一行的XML文档数据，之后将其文档数据。addendchild到XML中
            XmlDeclaration dce = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dce);
            //4、必须创建一个根节点，之后将addendchild到XML
            XmlElement order = doc.CreateElement("BookOne");
            doc.AppendChild(order);


            //5、创建子节点在根节点中，因为只能由一个根节点，其他所有显示的节点都必须显示在根节点中
            XmlElement book1 = doc.CreateElement("Book1");
            order.AppendChild(book1);

            XmlElement book2 = doc.CreateElement("Book2");
            book2.InnerText = "重生之我在黑色帝国泡妞";
            book1.AppendChild(book2);

            //addendchild添加到根节点中
            //6、之后可以创建很多子节点，也可以在子节点里面创建子节点，只不过要添加到对应的节点当中去

            //将其全部添加到子节点book2种
            XmlElement book2two = doc.CreateElement("Book2two");
            book2two.InnerText = "我在用修仙故事骗双修";
            book2.AppendChild(book2two);
            XmlElement book21 = doc.CreateElement("Book21");
            book21.InnerText = "嘿嘿";
            book2.AppendChild(book21);

            //将其添加到子节点book1种
            XmlElement book3 = doc.CreateElement("book3");
            book3.InnerText = "万古神帝";
            book1.AppendChild(book3);
            //XmlElement book3 = doc.CreateElement("Book3");
            //book3.InnerText = "文憔悴独断万古";
            //order.AppendChild(book3);
            //7、最后将其保持XML对象.sert,将其保存并且设置name
            doc.Save("Book.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();
        }
    }
}
