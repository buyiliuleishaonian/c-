using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象练习
{
    public class Son类 :Father
    {
        public Son类(string lastname,decimal money,string blondtyoe) : base(lastname,money,blondtyoe)
        {
            
        }
        public void PlayGame()
        {
            Console.WriteLine("儿子会玩游戏");
        }
    }
}
