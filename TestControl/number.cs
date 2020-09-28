using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestControl
{
    class number
    {
        int a;
        int b;
        int c;
        int e;
        int f;

        public number(int i, int k, int l, int m, int y)
        {
            a = i;
            b = k;
            c = l;
            e = m;
            f = y;
        }

        public int[] getArr()
        {
            return new int[] { a, b, c, e, f };
        }
    }
}
