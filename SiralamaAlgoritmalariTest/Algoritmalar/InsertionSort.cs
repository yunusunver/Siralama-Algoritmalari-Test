using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiralamaAlgoritmalariTest.Algoritmalar
{
    public class InsertionSort
    {
        private int[] arr;

        public InsertionSort(int[] arr)
        {
            this.arr = arr;
        }

        public void  insertion_sort()
        {
          
            for (int j = 1; j < arr.Length; j++)
            {
                int key = arr[j];
                int i = j - 1;
                while (i >= 0 && arr[i] > key)
                {
                    arr[i + 1] = arr[i];
                    i = i - 1;
                }
                arr[i + 1] = key;
            }
           
        }
    }
}
