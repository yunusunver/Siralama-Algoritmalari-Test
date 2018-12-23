using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiralamaAlgoritmalariTest.Algoritmalar
{
    public class CountingSort
    {
        private int[] arr;

        public CountingSort(int[] arr)
        {
            this.arr = arr;
        }

        public void Counting_Sort()
        {
            int[] sortedArray = new int[arr.Length];

            
            int minVal = arr[0];
            int maxVal = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minVal) minVal = arr[i];
                else if (arr[i] > maxVal) maxVal = arr[i];
            }

            
            int[] counts = new int[maxVal - minVal + 1];

        
            for (int i = 0; i < arr.Length; i++)
            {
                counts[arr[i] - minVal]++;
            }

           
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

           
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[arr[i] - minVal]--] = arr[i];
            }

            
        }
    }
}
