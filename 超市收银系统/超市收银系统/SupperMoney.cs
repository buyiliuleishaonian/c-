using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    public class SupperMoney
    {
        //首先需要建立一个仓库的对象
        //之后需要对仓库的货品给与数量
        CangKu ck = new CangKu();//创建了电脑，三星，香蕉的货柜
        /// <summary>
        /// 给仓库的货柜，给进货物和数量
        /// </summary>
        public SupperMoney()
        {
            ck.JinHuo("电脑",1000);
            ck.JinHuo("三星",1000);
            ck.JinHuo("香蕉",1000);
        }
        /// <summary>
        /// 和用户交谈
        /// </summary>
        public void Jiaoliu()
        {
            Console.WriteLine("欢迎光临，你需要买什么");
            Console.WriteLine("这里有电脑，三星手机，香蕉");
            string intype = Console.ReadLine();
            Console.WriteLine("您需要多少个？");
            int numbers = Convert.ToInt32(Console.ReadLine());
            //这里我们给定的是单个货物，要是多个不同的货物呢？
            Porduck[] por= ck.QuHua(intype, numbers);
            double realmoney = Money(por); Porduck[] pro = ck.QuHua(intype, numbers);
            Console.WriteLine( "一共需要{0}钱",realmoney);
            Console.WriteLine("请你选择打折的方式:1、不打折===2、打9折===3、满500减50");
            string input = Console.ReadLine();
            CalFather cf = Getcal(input);
            Console.WriteLine("打完折之后，一共{0}钱", cf.RealMoney(realmoney)) ;
            //最后将其小票输出
            foreach (var item in por)
            {
                Console.WriteLine("购物清单 +\r\n" + item.Name + "\t" + "单号" +item.ID+"\t"+item.Price);
            }
        }
        /// <summary>
        /// 通过顾客的需要的类型和数量，将总价和货物拿出。
        /// </summary>
        /// <param name="intype">货物的名字</param>
        /// <param name="numbers">货物的数量</param>
        /// <returns></returns>
        public double Money(Porduck[] por)
        {
            
            double money = 0;
            //这样不管是单个货物，还是多个数量的都可以计算总价钱
            for (int x=0; x<por.Length;x++)
            {
              money += por[x].Price;
            }
            return money;
        }

        /// <summary>
        /// 通过简单工厂模式，来对于打折这个事情实现多态
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public CalFather Getcal(string input)//根据用户的输入，判断打折方式
        {
            CalFather cf = null ;
            switch (input)
            {
                case "1":  cf=new  calNormal();
                    break;
                case "2":cf= new calRate(0.9);
                    break;
                case "3":cf = new calMN(500,100);
                    break;
            }
            return cf;
        }
        /// <summary>
        /// 展示仓库货柜
        /// </summary>
        public  void Test()
        {
            ck.Show();
        }
    }
}
