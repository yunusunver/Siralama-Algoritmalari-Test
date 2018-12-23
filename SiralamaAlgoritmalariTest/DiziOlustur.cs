using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiralamaAlgoritmalariTest
{
    public class DiziOlustur
    {
        public int[] Olustur()
        {
            int [] dizi=new int[100000];
            for (int i = dizi.Length; i>0; i--)
            {
                dizi[dizi.Length-i] = i;
            }
            return dizi;
        }
    }
}
