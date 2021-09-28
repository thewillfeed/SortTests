using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Timers;

namespace SortTests
{

    
    public partial class Form1 : Form
    {
        BubbleSortClass bubbleSortClass;
        InsertionSortClass insertionSortClass;
        QuickSortClass quickSortClass;
        int[] array1;
        int[] array2;
        int[] array3;
        Label[] bubbleSortTextBoxes;
        Label[] insertionSortTextBoxes;
        Label[] quickSortTextBoxes;

        public delegate void Progr(int x);

        System.Timers.Timer aTimer;

        private void SetTimer()
        {
            aTimer = new System.Timers.Timer(15);

            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        void CheckThreads()
        {
            int check = 0;
            bool statShown1 = false;
            bool statShown2 = false;
            bool statShown3 = false;
            

            if (bubbleSortClass.Finished == false) Console.WriteLine("Bubble Sort Thread is working atm");
            else { 
                Debug.WriteLine("Bubble Sort Thread has done it's job " + bubbleSortClass.Timer.ToString(@"mm\:ss\:ffff"));
                if (!statShown1) {
                ShowTextStat(bubbleSortTextBoxes, bubbleSortClass);
                    statShown1 = true;
                }
                // bubbleState.Text = "Finished";
                check++;
            }
            if (quickSortClass.Finished == false) Console.WriteLine("Quick Sort Thread is working atm");
            else
            {
                Debug.WriteLine("Quick Sort Thread has done it's job `" + quickSortClass.Timer.ToString(@"mm\:ss\:ffff"));
                if (!statShown2)
                {
                    ShowTextStat(quickSortTextBoxes, quickSortClass);
                    statShown2 = true;
                }
                //quickSortState.Text = "Finished";
                check++;
            }
            if (insertionSortClass.Finished == false) Console.WriteLine("Insertion Sort Thread is working atm");
            else
            {
                Debug.WriteLine("Insertion Sort Thread has done it's job " + insertionSortClass.Timer.ToString(@"mm\:ss\:ffff"));
                if (!statShown3)
                {
                    ShowTextStat(insertionSortTextBoxes, insertionSortClass);
                    statShown3 = true;
                }
                //insertionState.Text = "Finished";
                check++;
            }
            if(check == 3) { aTimer.Stop(); }
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {            
            this.CheckThreads();
        }

        int n; //arraysize;

        int[] unsortedArray;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.Name = "Main";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Progr prBubble = ProgressBubble;
            Progr prIns = ProgressInsertion;
            Progr prQuick = ProgressQuick;
            bubbleSortClass = new BubbleSortClass(prBubble);
            insertionSortClass = new InsertionSortClass(prIns);
            quickSortClass = new QuickSortClass(prQuick);
            bubbleSortTextBoxes = new Label[3] { bubbleCompTxt, bubbleSwapsTxt, bubbleTimeElapsed };
            insertionSortTextBoxes = new Label[3] { insertionCompTxt, insertionSwapsTxt, insertionTimeElapsedTxt };
            quickSortTextBoxes = new Label[3] { quickSortCompTxt, quickSortSwapTxt, quickSortTimeElapsedTxt };


        }
        
        private void ProgressBubble(int x) //сюды надо передать прогресс бар
        {
            if (InvokeRequired)
            {
                Progr pp = this.ProgressBubble;
                this.Invoke(pp,x);
            }
            if (x > 100) x = 100;
                bubbleState.Text = x.ToString();
                progressBarBubble.Value = x;                 
        }
        
        private void ProgressInsertion(int x)
        {
            if (InvokeRequired)
            {
                Progr pp = this.ProgressInsertion;
                this.Invoke(pp, x);
            }
            if (x > 100) x = 100;
            insertionState.Text = x.ToString();
            progressBarInsertion.Value = x;
        }

        private void ProgressQuick(int x)
        {
            if (InvokeRequired)
            {
                Progr pp = this.ProgressQuick;
                this.Invoke(pp, x);
            }
            if (x > 100) x = 100;
            quickSortState.Text = x.ToString();
            progressBarQuick.Value = x;
        }

        abstract class Sorting
        {
            private bool finished;
            private int checks;
            private int swaps;      
            protected Progr pr;
            //private TimeSpan timer;
            private Stopwatch stopwatch = new Stopwatch();

            public int Swaps { get { return swaps; } set { swaps = value; } }
            public int Checks { get { return checks; } set { checks = value; } }
            public TimeSpan Timer { get { return stopwatch.Elapsed; } }
            public bool Finished { get { return finished; } set { finished = value; } }

            abstract public void Sort(int[] array);
            

            protected void StartTimer()
            {
                stopwatch.Start();

            }

            protected void HaltTimer()
            {
                stopwatch.Stop();
            }          
        }

        class BubbleSortClass : Sorting
        {
            public BubbleSortClass(Progr pr)
            {
                this.pr = pr;
            }

            override public void Sort(int[] array)
            {
                Finished = false;
                Checks = 0;
                Swaps = 0;
                StartTimer();
                BubbleSort(array);
                HaltTimer();
                Finished = true;
            }

            void BubbleSort(int[] array)
            {
                pr(0);
                for (int i = 0; i + 1 < array.Length; i++)
                {
                    
                    for (int j = 0; j + 1 < array.Length - i; j++)
                    {
                        Checks++;
                        if (array[j + 1] < array[j])
                        {
                            Swaps++;
                            (array[j + 1], array[j]) = (array[j], array[j + 1]);    //tuple swap
                        }
                    }    
                        //int progress = 10*i;
                       pr(i*100/array.Length);
                    
                }
                pr(100);
            }

        }

        class InsertionSortClass : Sorting 
        {
            public InsertionSortClass(Progr pr)
            {
                this.pr = pr; //????
            }
            public override void Sort(int[] array)
            {
                Finished = false;
                Checks = 0;
                Swaps = 0;
                StartTimer();
                InsertionSort(array);
                HaltTimer();
                Finished = true;
            }

            public void InsertionSort(int[] array) //Сортировка вставками UNTESTED
            {
                pr(0);
                for (int i = 0; i < array.Count(); i++)
                {
                    var item = array[i];
                    var currentIndex = i;
                    Checks++;

                    while (currentIndex > 0 && array[currentIndex - 1] > item)
                    {
                        Checks++;
                        Swaps++;
                        array[currentIndex] = array[currentIndex - 1];
                        currentIndex--;
                    }

                    pr(i * 100 / array.Length);
                    array[currentIndex] = item;
                     //
                }
                pr(100);
            }
        }


        class QuickSortClass : Sorting
        {
            int unsortArraySize;  //God forgive me for this
            public QuickSortClass(Progr pr)
            {
                this.pr = pr;
            }
            public override void Sort(int[] array)
            {
                Finished = false;
                Checks = 0;
                Swaps = 0;
                unsortArraySize = array.Length;

                StartTimer();
                pr(0);
                QuickSort(array,0,array.Length-1);
                pr(100);
                HaltTimer();

                Finished = true;
            }
            int Partition(int[] array, int low,
                                    int high)
            {
                                                                    // Selecting a pivot point.
                int pivot = array[high];

                int lowIndex = (low - 1);

                                                                   // Reordering the collection.
                for (int j = low; j < high; j++)
                {
                    Checks++;
                    if (array[j] <= pivot)
                    {
                        Swaps++;

                        lowIndex++;

                        int temp = array[lowIndex];
                        array[lowIndex] = array[j];
                        array[j] = temp;
                    }
                }

                Swaps++;

                int temp1 = array[lowIndex + 1];
                array[lowIndex + 1] = array[high];
                array[high] = temp1;

                return lowIndex + 1;
            }
            void QuickSort(int[] array, int low, int high)
            {
                if (low < high)
                {
                    int partitionIndex = Partition(array, low, high);
                    //pr(1/(high-low)*100/unsortArraySize); //Showing progress
                                                                            //Sorting the array recursevly
                    QuickSort(array, low, partitionIndex - 1);
                    QuickSort(array, partitionIndex + 1, high);
                }

            }
        }


        void GenerateRandomNumArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1,100000);
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            

            n = Convert.ToInt32(arraySizeTextBox.Text);
            if(n==null || n < 0) n = 10000;

            unsortedArray = new int[n];     //leaving it here for testing purposes
            GenerateRandomNumArray(unsortedArray);

            array1 = new int[n];
            array2 = new int[n];
            array3 = new int[n];

            unsortedArray.CopyTo(array1, 0);
            unsortedArray.CopyTo(array2, 0);
            unsortedArray.CopyTo(array3, 0);            

            //Task taskQuick = new Task(() => Console.WriteLine("Thread: "+ Thread.CurrentThread.Name));
            SetTimer();
            //Parallel.Invoke(() => bubbleSortClass.Sort(array1),()=>insertionSortClass.Sort(array2)); //,()=>quickSortClass.Sort(array3)
            Thread tQuick1 = new Thread(() => bubbleSortClass.Sort(array1));
            Thread tQuick2 = new Thread(() => insertionSortClass.Sort(array2));
            Thread tQuick3 = new Thread(() => quickSortClass.Sort(array3));
            tQuick1.Start();
            tQuick2.Start();
            tQuick3.Start();

            //taskQuick.Start();
            Task.WaitAll();
            //ShowTextStat(bubbleSortTextBoxes,bubbleSortClass);
            //ShowTextStat(insertionSortTextBoxes, insertionSortClass);
            //ShowTextStat(quickSortTextBoxes, quickSortClass);
            //Это база, но она пока плохо работает в синхроне
            //testListBox.Items.Add("Thread:" + Thread.CurrentThread.Name);
            //QuickSort(unsortedArray,0,unsortedArray.Length - 1);
            //taskQuick.Wait();
            


        }
        delegate void ShowStat(Label[] labels, Sorting SortClass);
        void ShowTextStat(Label[] labels, Sorting SortClass)
        {
            if (InvokeRequired)
            {              
                ShowStat showStat = this.ShowTextStat;
                this.Invoke(showStat,labels,SortClass);
            }
            labels[0].Text = "Comp: " + SortClass.Checks.ToString();
            labels[1].Text = "Swaps: "+ SortClass.Swaps.ToString();
            labels[2].Text = "Time elapsed (seconds): " + SortClass.Timer.ToString(@"mm\:ss\:ffff");

        }

        void InsertArrayIntoListBox(ListBox listBox, int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                listBox.Items.Add(array[i]);
            }
            
        }

        private void showBubbleArray_Click(object sender, EventArgs e)
        {
            InsertArrayIntoListBox(testListBox, array1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertArrayIntoListBox(listBox1, array2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertArrayIntoListBox(listBox2, array3);
        }
    }
}
