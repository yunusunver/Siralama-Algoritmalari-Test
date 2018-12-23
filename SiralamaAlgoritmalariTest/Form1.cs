using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SiralamaAlgoritmalariTest.Algoritmalar;

namespace SiralamaAlgoritmalariTest
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
       
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new DiziOlustur().Olustur();
           

            var secim = algoritmaListesi.SelectedIndex;

            if (secim==0)
            {
                SelectionSort selectionSort = new SelectionSort(arr);
                Stopwatch stopwatch=new Stopwatch();
                stopwatch.Start();
                selectionSort.SelectionSortAlgoritm();
                stopwatch.Stop();
                TimeSpan sure = stopwatch.Elapsed;
                lblSelection.Text = sure.ToString();

            }
            else if (secim==1)
            {

                InsertionSort insertionSort = new InsertionSort(arr);
                Stopwatch stopwatch=new Stopwatch();
                stopwatch.Start();
                insertionSort.insertion_sort();
                stopwatch.Stop();
                TimeSpan sure = stopwatch.Elapsed;
                lblInsertion.Text = sure.ToString();

            }
            else if (secim==2)
            {
                BubbleSort bubbleSort = new BubbleSort(arr);
                Stopwatch stopwatch=new Stopwatch();
                stopwatch.Start();
                bubbleSort.Bubble_Sort();
                stopwatch.Stop();
                TimeSpan sure=stopwatch.Elapsed;
                lblBubble.Text = sure.ToString();
            }
            else if (secim==3)
            {

                CountingSort countingSort = new CountingSort(arr);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                countingSort.Counting_Sort();
                stopwatch.Stop();
                TimeSpan sure = stopwatch.Elapsed;
                lblCounting.Text = sure.ToString();
            }
            else if (secim == 4)
            {

                QuickSort quickSort = new QuickSort(arr);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                quickSort.sort_quick();
                stopwatch.Stop();
                TimeSpan sure = stopwatch.Elapsed;
                lblQuick.Text = sure.ToString();
            }
            else if (secim == 5)
            {
                
                MergeSort mergeSort = new MergeSort(arr);
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                mergeSort.sort_merge();
                stopwatch.Stop();
                TimeSpan sure = stopwatch.Elapsed;
                lblMerge.Text = sure.ToString();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            float fcpu = CPU.NextValue();
            float dram = RAM.NextValue();

            

            circularProgressBar1.Value = (int) fcpu;
            circularProgressBar1.Text = string.Format("{0:0.00}%", fcpu);


            circularProgressBar2.Value = (int)dram;
            circularProgressBar2.Text = string.Format("{0:0.00}%", dram);
        }
    }
}
