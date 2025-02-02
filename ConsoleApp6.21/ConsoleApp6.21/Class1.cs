using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6._21
{
    class CXZ
    {
        private int _ZXC;
        public CXZ(int ZXC)
        {
            _ZXC = ZXC;
        }
        public int ZXCV()
        {
            if (_ZXC < 2)
            {
                return 11;
            }
            else if (_ZXC >= 2 && _ZXC < 5)
            {
                return 12;
            }
            else
            {
                return 13;
            }
        }
    }
}
