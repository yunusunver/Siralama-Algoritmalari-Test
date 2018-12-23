using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiralamaAlgoritmalariTest.Algoritmalar
{
    public class QuickSort
    {
        private int[] arr;
        int q;
        public QuickSort(int[] arr)
        {
            this.arr = arr;
        }

        public void sort_quick()
        {
          
            quick_sort(arr, 0, arr.Length-1);
      
        }

        
        public void quick_sort(int[] dizi, int p, int r)
        {
            if (p < r)
            {
                partition(dizi, p, r);
                quick_sort(dizi, p, q);
                quick_sort(dizi, q + 1, r);
            }
        }
        public void partition(int[] dizi, int p, int r)
        {
            int x = dizi[p];
            int i = p - 1;
            int j = r + 1;
            while (true)
            {
                do
                {
                    j--;
                }
                while (dizi[j] > x);

                do
                {
                    i++;
                }
                while (dizi[i] < x);

                if (i < j)
                {
                    int gecici = dizi[i];
                    dizi[i] = dizi[j];
                    dizi[j] = gecici;
                }
                else
                {
                    q = j;
                    break;
                }
            }
        }
    }
}
