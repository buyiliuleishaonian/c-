using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 石头剪刀布
{
    public  class Player
    {
        /// <summary>
        /// 对于玩家的出拳，是我们选择的
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int Playernumber(string name)
        {
            int playernumber = 0;
            switch (name)
            {
                case "石头":
                    playernumber = 1;
                    break;
                case "剪刀":
                    playernumber = 2;
                    break;
                case "布":
                    playernumber = 3;
                    break;
            }
            return playernumber;
        }
    }
}
