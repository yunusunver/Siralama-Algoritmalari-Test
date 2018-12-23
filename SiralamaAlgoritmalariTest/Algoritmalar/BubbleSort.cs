using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiralamaAlgoritmalariTest.Algoritmalar
{
    public class BubbleSort
    {
        private int [] arr;

        public BubbleSort(int [] arr)
        {
            this.arr = arr;
        }

        public void  Bubble_Sort()
        {
         
            int gecici;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = 1; j <= arr.Length - 1; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        gecici = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = gecici;
                    }
                }
            }
        

            
        }
    }
}
