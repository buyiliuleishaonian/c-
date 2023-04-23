using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
     /// <summary>
    /// 构建仓库，进货，取货，展示仓库
    /// </summary>
    public class CangKu
    {
        //建立存储物资的模块，将固定的物品放在一个地方
        //这样创建，就是创建类型模块集合，
        //集合里面每一个元素，又是一个集合。这样就可以将一个类型的物品放在同一个模块
        List<List<Porduck>> list=new List<List<Porduck>>();
        //在存放物品之前，就需要将存放同一个物品模块建立
        /// <summary>
        /// 构造函数，给货架上货物和数量
        /// </summary>
        public CangKu()
        {
            //物品模块少的话这样做
            list.Add(new List<Porduck>());
            list.Add(new List<Porduck>());
            list.Add(new List<Porduck>());
        }
        
        /// <summary>
        /// 还需要将仓库的物品进行展示
        /// </summary>
        public void Show()
        {
            //通过下标将每个货架都展示，并且可以展示数量，类别和价格
            foreach (var item in list)
            {
                //item表示为list的每个元素，list[]表示为每个元素其中集合的每个元素,其为各种货物的父类集合。
                //将每个货架上面装的什么，多少个，单价全部展示。
                Console.WriteLine("{0}是存放{1}个每个{2}元", item[0].Name, item.Count, item[0].Price);
            }
        }

        //最后开始对放置进行设置
        //首先放置之前，需要判断类型和数量
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="Type">货物的类型</param>
        /// <param name="count">货物的数量</param>
        public void JinHuo(string inType,int count)
        {
            for (int x=0;x<count;x++)
            {
                switch (inType)
                {
                    case "电脑":
                        list[0].Add(new DianNao(Guid.NewGuid().ToString(),"电脑",5000.0));
                        break;
                    case "香蕉":
                        list[1].Add(new Xiangjiao(Guid.NewGuid().ToString(), 20.0,"香蕉")) ;
                        break;
                    case "三星":
                        list[2].Add(new Sanxing(Guid.NewGuid().ToString(),3000.0,"三星"));
                        break;
                }
            }
        }


        /// <summary>
        /// 取货
        /// </summary>
        /// <param name="stytype">货物类型</param>
        /// <param name="count">货物数量</param>
        /// <returns></returns>
        public Porduck[] QuHua(string outType,int count)//给定了取货的物品和数量
        {
            Porduck[] por = new Porduck[count];
            //对于货物，首先判断其归于那个货架，之后判断数量是否还足够
            for (int i = 0; i < count; i++)
            {
                switch (outType)
                {
                    //因为每个list元素都是一个集合
                    case "电脑":
                        if (list[0].Count > count)
                        {
                            //每次都将货架上的第一个拿走
                            //因为是一个引用类型转递，所以需要list[0]的第一个下标移除
                            por[i]=list[0][0];
                            list[0].RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("数量不够");
                        }
                        break;
                    case "香蕉":
                        if (list[1].Count > count)
                        {
                            por[i] = list[1][0];
                            list[1].RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("数量不够");
                        }
                        break;
                    case "三星":
                        if (list[2].Count > count)
                        {
                            por[i] = list[2][0];
                            list[2].RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("数量不够");
                        }
                        break;
                }
            }
            //最后输出集合
            return por;
        }
    }
}
