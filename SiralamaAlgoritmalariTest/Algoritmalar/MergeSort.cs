using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiralamaAlgoritmalariTest.Algoritmalar
{
    public class MergeSort
    {
        private int[] arr;

        public MergeSort(int[] arr)
        {
            this.arr = arr;
        }


        public void sort_merge()
        {
            
             SortMerge(arr, 0, arr.Length - 1);
        }

        public void MainMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);



            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }



            while (left <= eol)
                temp[pos++] = numbers[left++];



            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }



        public int[] SortMerge(int[] numbers, int left, int right)
        {
            int mid;     
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }

            return numbers;
        }


    }
}
