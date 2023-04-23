using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 飞行棋
{
    public enum Name
    {

    }
    public struct People
    {
        public int age;
    }
    internal class Program
    {
        //用静态数组来，描述全局地图
        public static int[] nums = new int[100];
        //用静态数组来，描述A和B玩家的位置
        public static int[] PlayerPos = new int[2];
        public static string[] PlayerName = new string[2];
        public static bool[] Ton = new bool[2];
        static void Main(string[] args)
        {
            //1、先做游戏头
            GameShow();

            //还需要输入玩家姓名
            #region   输入游戏名
            Console.WriteLine("请输入玩家A的姓名");
            PlayerName[0] = Console.ReadLine();
            while (PlayerName[0] == "")
            {
                Console.WriteLine("输入不能为空，请重新输入");
                PlayerName[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerName[1] = Console.ReadLine();
            while (PlayerName[1] == "" || PlayerName[1] == PlayerName[0])
            {
                if (PlayerName[1] == "")
                {
                    Console.WriteLine("输入不能为空,请重新输入");
                    PlayerName[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("输入不能和A玩家相同，请重新输入");
                    PlayerName[1] = Console.ReadLine();
                }
            }
            #endregion
            //2、初始化，就是让int数组里面的元素变为string类型
            //来构建地图的过程
            //构建地图的数组，当这个数组在多个方法里面都要调用时，直接将其构建成静态变量
            //将数组内，固定等于1的值，给予特殊的关卡
            //这里他首先设定了几个特定关卡的数组
            //当地图数组，里面的下标等于其特殊关卡数组元素的值时，设定为特殊关卡
            Console.Clear();
            GameShow();
            Console.WriteLine("{0}的士兵是A", PlayerName[0]);
            Console.WriteLine("{0}的士兵是B", PlayerName[1]);
            ChiShiHua();//必须初始化地图，要不然地图，没有修改
            //2、当然我这里想要建立一个随机数，然后通过随机数的范围来地图设定特殊关卡

            //3、画出地图
            FistHangDiTu();
            //4开始玩游戏
            while (PlayerPos[0] < 100 && PlayerPos[1]<100)
            {
                if (Ton[0] == false)
                {
                    Game(0);
                }
                else
                {
                    Ton[0] = false;
                }
                if (PlayerPos[0]>=99)
                {
                    Console.WriteLine("{0}胜利", PlayerName[0]);
                    break;
                }
                if (Ton[1]==false)
                {
                    Game(1);
                }
                else 
                {
                    Ton[1] = false;
                }
                if (PlayerPos[1]>=99)
                {
                    Console.WriteLine("{0}胜利", PlayerName[1]);
                    break;
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 生成游戏名
        /// </summary>
        public static void GameShow()
        {
            Console.BackgroundColor = ConsoleColor.White;//这是调用别的类中的方法，是枚举类型所以需要.出来
            Console.ForegroundColor = ConsoleColor.Green;//显示控制台前景的代码
            //枚举类型
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********蒋国文第一个.exe*********");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("***********************************");
        }
        /// <summary>
        /// 将一个数组，所有的元素通过随机数生成代替完成
        /// </summary>
        /// <param name="nums"></param>
        public static void RandomNum()//因为调用的时静态变量不同输入参数列表
        {
            Random num = new Random();
            for (int x = 0; x < nums.Length; x++)
            {
                nums[x] = num.Next(0, 4);
            }
        }
        /// <summary>
        /// 通过固定数组里面的值，将一个数组下标对应固定数组元素的值
        /// 赋值为定值
        /// </summary>
        /// <param name="nums"></param>
        public static void ChiShiHua()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };
            for (int x = 0; x < luckyturn.Length; x++)
            {
                int number = luckyturn[x];
                nums[number] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            for (int x = 0; x < landMine.Length; x++)
            {
                int number = landMine[x];
                nums[number] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };
            for (int x = 0; x < pause.Length; x++)
            {
                int number = pause[x];
                nums[number] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 89, 90 };
            for (int x = 0; x < timeTunnel.Length; x++)
            {
                int number = timeTunnel[x];
                nums[number] = 4;
            }

        }
        /// <summary>
        /// 将地图的的所有关卡全部输出
        /// </summary>
        public static void FistHangDiTu()
        {
            #region  第一横行
            Console.WriteLine("关卡 “小”：正常  “炸”：炸弹  “洞”：穿梭  “位”：“幸运轮盘");
            for (int x = 0; x < 30; x++)//循环30此则可以将第一行地图全部输出
            {
                Console.Write(HuaDiTu(x));
            }
            #endregion
            Console.WriteLine();//画完第一行之后需要换行

            //画第一竖行
            //因为竖行表示前29位都为空
            //做一件事情需要做很多次事情则需要for嵌套
            #region 第一竖行
            for (int x = 30; x < 35; x++)
            {
                for (int y = 0; y < 29; y++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(HuaDiTu(x));
            }
            #endregion


            //画第二横行
            #region  画第二横行，递减
            for (int x = 65; x > 35; x--)
            {
                Console.Write(HuaDiTu(x));
            }
            #endregion
            Console.WriteLine();
            //画第二竖行
            for (int x = 65; x < 70; x++)
            {
                Console.WriteLine(HuaDiTu(x));
            }
            //画最后一条横行
            for (int x = 70; x < 100; x++)
            {
                Console.Write(HuaDiTu(x));
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 从初始化地图里面，封装出来的方法
        /// 输出一个值，在地图里面输出就行
        /// </summary>
        /// <param name="x"></param>
        public static string HuaDiTu(int x)
        {
            #region   判断地图输出的值先判断A，B的位置，再画关卡
            //
            string name = "";
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == x)//当两个玩家位置，相同并且都在地图上时输出
            {
                Console.ForegroundColor = ConsoleColor.Black;
                //Console.Write("<>");
                return name = "<>";
            }
            else if (PlayerPos[0] == x)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                //Console.Write("A");
                return name = "A";
            }
            else if (PlayerPos[1] == x)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                //Console.Write("B");
                return name = "B";
            }
            else
            {
                switch (nums[x])
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        //Console.Write("位");
                        return name = "位";
                    //break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        //Console.Write("炸");
                        return name = "炸";
                    //break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        //Console.Write("洞");
                        return name = "洞";
                    //break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        //Console.Write("小");
                        return name = "小";
                        //break;

                }
            }
            #endregion
        }
        /// <summary>
        /// 开始游戏，随机生成要移动的距离
        /// 并且改变位置
        /// </summary>
        /// <param name="name"></param>
        public static void Game(int name)
        {
                Console.WriteLine("{0}玩家按下任意键开始游戏", PlayerName[name]);
                Console.ReadKey(true);//调用console类中的.readkey();方法有两种，
                Random num = new Random();
                int number = num.Next(1, 7);//生成一个运动距离的随机数
                Console.WriteLine("{0}玩家移动{1}步,按下任意键继续", PlayerName[name], number);
                PlayerPos[name] += number;
                FangWei();
                Console.ReadKey(true);
                Console.WriteLine("移动完成，按下任意键继续");
                Console.ReadKey(true);
                if (PlayerPos[0] == PlayerPos[1])
                {
                    Console.WriteLine("{0}和{1}同位置，{2}后退6格", PlayerName[name], PlayerName[1-name], PlayerName[1-name]);
                    PlayerPos[1-name] -= 6;
                }
                else
                {
                    switch (nums[PlayerPos[name]])
                    {
                        case 0:
                            Console.WriteLine("{0}玩家踩中了小，一切正常", PlayerName[name]);
                            break;
                        case 1:
                            Console.WriteLine("{0}踩中了位，幸运轮盘，选择1--前进6格，2--{1}炸退6格", PlayerName[name], PlayerName[1-name]);
                            string input = Console.ReadLine();
                            while (true)
                            {
                                if (input == "1")
                                {
                                    Console.WriteLine("{0}玩家前进6格", PlayerName[name]);
                                    PlayerPos[name] += 6;
                                    break;
                                }
                                else if (input == "2")
                                {
                                    Console.WriteLine("{0}玩家退6格", PlayerName[1-name]);
                                    PlayerPos[1-name] -= 6;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("输入不对，请重新输入");
                                    input = Console.ReadLine();
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("{0}玩家踩上了炸弹，退6格", PlayerName[name]);
                            PlayerPos[name] -= 6;
                            break;
                        case 3:
                            Console.WriteLine("{0}玩家踩上了洞，暂停一局", PlayerName[name]);
                            Ton[name]= true;
                            break;
                    }//switch
                }//if-else if
            Console.ReadKey(true);
            FangWei();
            Console.Clear();
            FistHangDiTu();
        }
        /// <summary>
        /// 确保两个玩家的位置在游戏内部
        /// </summary>
        public static void FangWei()
        {
            if (PlayerPos[0] >= 99)
            {
                PlayerPos[0] = 99;
            }
           else if (PlayerPos[0]<=0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[1] >= 99)
            {
                PlayerPos[1] = 99;
            }
            else if (PlayerPos[1] <= 0)
            {
                PlayerPos[1] = 0;
            }
        }
    }
}
