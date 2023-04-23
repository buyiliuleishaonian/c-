using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 石头剪刀布
{
   public  class Computer
    {
        //因为，要将随机生成的数字，对应的出拳，传递给labnumber
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 要随机生成出拳，之后将出拳给labnumber
        /// </summary>
        /// <returns></returns>
        public int Computernumber()
        {
            //电脑是随机生成的
            Random number = new Random();
            int computernumber=number.Next(1,4);
            switch (computernumber)
            {
                case 1: this.Name = "石头";
                    break;
                case 2:this.Name = "剪刀";
                    break;
                case 3:this.Name = "布";
                    break;
            }
            return computernumber;
        }
    }
}
