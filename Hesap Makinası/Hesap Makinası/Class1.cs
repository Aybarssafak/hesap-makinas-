using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinası
{
    internal class Class1
    {
        public int carpma(int s1, int s2)
        {
            int sonuc = s1 * s2;
            return sonuc;
        }
        public int bolme(int s1, int s2)
        {
            int sonuc = s1 / s2;
            return sonuc;
        }
        public int toplama(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }
        public int cikartma(int s1, int s2)
        {
            int sonuc = s1 - s2;
            return sonuc;
        }

    }
}
