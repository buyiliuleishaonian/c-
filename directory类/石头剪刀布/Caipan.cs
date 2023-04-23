using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 石头剪刀布
{
    public enum Jieguo
    {
        玩家赢,
        电脑赢,
        平局
    }
    public class Caipan
    {
        public static Jieguo Caipanout(int playernumber,int computernumber)
        {
            
            switch (playernumber-computernumber)
            {
                case -1:
                case  2:
                    return Jieguo.玩家赢;
                case 0:
                    return Jieguo.平局;
                default:
                    return Jieguo.电脑赢;
                 
            }
           
        }
    }
}
