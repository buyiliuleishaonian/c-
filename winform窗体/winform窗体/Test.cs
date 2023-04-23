using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform窗体
{
    public static class Test
    {
      static  Form1 _frm1;
        public static Form1 FRm1
        {
            get { return _frm1; }
            set { _frm1 = value; }
        }
    }
}
