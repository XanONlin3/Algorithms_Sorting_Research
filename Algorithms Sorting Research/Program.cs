using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text;
using System.Diagnostics;

namespace Algorithms_Sorting_Research
{
    class Program
    {
        static void Main(string[] args)
        {

            const int SIZE = 100000;		//change to get diff input sizes during testing 10,000  100,000  1,000,000  10,000,000  100,000,000  500,000,000

            int[] arrayBS = new int[SIZE]; 		//bubble
            int[] arraySS = new int[SIZE];  	//selection
            int[] arrayMS = new int[SIZE];  	//merge
            int[] arrayQS = new int[SIZE]; 	    //quick
            int[] arrayHS = new int[SIZE];		//heap


            // Bubble Sort -----------------------------------------------------------
            Console.WriteLine("Bubble sort");
            //Uncomment out which type of data you want
            arrayBS = random(SIZE);
            //arrayBS = reverse(SIZE);
            //arrayBS = fewUnique(SIZE);
            //arrayBS = almostSorted(SIZE);
          
        /*    Console.WriteLine("Bubble before: ");
            foreach (var item in arrayBS)
            {
                Console.Write(item.ToString()+ " ");
            } */

            
            string start = "Bubble Sort  " + "Data Size: \n" + SIZE;
            System.IO.File.WriteAllText(@"C:\Sort.txt", start);            // CHANGE THIS FILE LOCATION TO MATCH YOUR TEXT FILE, CHANGE IT FOR EACH RUN
            
            for (int r = 0; r < 10; r++)
            {

                Stopwatch sw = new Stopwatch();
                sw.Start();
                bubblesort(arrayBS, SIZE);
                sw.Stop();
                long timebubble = sw.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                double timebubblesec = (timebubble * .000001);

                /*    Console.WriteLine("\nBubble after: ");
                    foreach (var item in arrayBS)
                    {
                        Console.Write(item.ToString() + " ");
                    } */

                Console.WriteLine("\nRun: {0} Bubble sort: {1} microseconds and {2} seconds", r, timebubble, timebubblesec);


                // Example #2: Write one string to a text file. 
                double text = timebubblesec;

                // Example #4: Append new text to an existing file. 
                // The using statement automatically closes the stream and calls  
                // IDisposable.Dispose on the stream object. 
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Sort.txt", true))                         // CHANGE THIS FILE LOCATION TO MATCH YOUR TEXT FILE
                {
                    file.WriteLine(text);
                }
            }
            // Selection Sort---------------------------------------------------------
            Console.WriteLine("Selection sort");
            //Uncomment out which type of data you want
            arraySS = random(SIZE);
            //arraySS = reverse(SIZE);
            //arraySS = fewUnique(SIZE);
            //arraySS = almostSorted(SIZE);

       /*     Console.WriteLine("\nSelection before: ");
            foreach (var item in arraySS)
            {
                Console.Write(item.ToString() + " ");
            } */

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Sort.txt", true))                     // CHANGE THIS FILE LOCATION TO MATCH YOUR TEXT FILE
            {
                file.WriteLine("\n\nSelection Sort  " + "Data Size: " + SIZE);
            }

            for (int r = 0; r < 10; r++)
            {

                Stopwatch sw2 = new Stopwatch();
                sw2.Start();
                selectionsort(arraySS, SIZE);
                sw2.Stop();
                long timeselection = sw2.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                double timeselectionsec = (timeselection * .000001);

                /*     Console.WriteLine("\nSelection after: ");
                     foreach (var item in arraySS)
                     {
                         Console.Write(item.ToString() + " ");
                     } */

                Console.WriteLine("\nRun: {0} Selection sort: {1} microseconds and {2} seconds", r, timeselection, timeselectionsec);

                double text = timeselectionsec;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Sort.txt", true))                             // CHANGE THIS FILE LOCATION TO MATCH YOUR TEXT FILE
                {
                    file.WriteLine(text);
                }
            }

            // Merge Sort ------------------------------------------------------------
            Console.WriteLine("Merge sort");
            //Uncomment out which type of data you want
            arrayMS = random(SIZE);
            //arrayMS = reverse(SIZE);
            //arrayMS = fewUnique(SIZE);
            //arrayMS = almostSorted(SIZE);

       /*     Console.WriteLine("\nMerge before: ");
            foreach (var item in arrayMS)
            {
                Console.Write(item.ToString() + " ");
            } */

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Sort.txt", true))                             // CHANGE THIS FILE LOCATION TO MATCH YOUR TEXT FILE
            {
                file.WriteLine("Merge Sort  " + "Data Size: " + SIZE);
            }

            for (int r = 0; r < 10; r++)
            {

                Stopwatch sw3 = new Stopwatch();
                sw3.Start();
                mergesort(arrayMS, 0, SIZE - 1);
                sw3.Stop();
                long timemerge = sw3.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                double timemergesec = (timemerge * .000001);


                /*    Console.WriteLine("\nMerge after: ");
                    foreach (var item in arrayMS)
                    {
                        Console.Write(item.ToString() + " ");
                    } */

                Console.WriteLine("\nRun: {0} Merge sort: {1} microseconds and {2} seconds", r, timemerge, timemergesec);

                double text = timemergesec;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Sort.txt", true))                             // CHANGE THIS FILE LOCATION TO MATCH YOUR TEXT FILE
                {
                    file.WriteLine(text);
                }

            }
            // Quick Sort ------------------------------------------------------------
            Console.WriteLine("Quick sort");
            //Uncomment out which type of data you want
            arrayQS = random(SIZE);
            //arrayQS = reverse(SIZE);
            //arrayQS = fewUnique(SIZE);
            //arrayQS = almostSorted(SIZE);

       /*     Console.WriteLine("\nQuick before: ");
            foreach (var item in arrayQS)
            {
                Console.Write(item.ToString() + " ");
            } */

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Sort.txt", true))                                             // CHANGE THIS FILE LOCATION TO MATCH YOUR TEXT FILE
            {
                file.WriteLine("Quick Sort  " + "Data Size: " + SIZE);
            }

            for (int r = 0; r < 10; r++)
            {

                Stopwatch sw4 = new Stopwatch();
                sw4.Start();
                quicksort(arrayQS, 0, SIZE - 1);
                sw4.Stop();
                long timequick = sw4.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                double timequicksec = (timequick * .000001);

                /*    Console.WriteLine("\nQuick after: ");
                    foreach (var item in arrayQS)
                    {
                        Console.Write(item.ToString() + " ");
                    } */

                Console.WriteLine("\nRun: {0} Quick sort: {1} microseconds and {2} seconds", r, timequick, timequicksec);

                double text = timequicksec;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Sort.txt", true))                                         // CHANGE THIS FILE LOCATION TO MATCH YOUR TEXT FILE
                {
                    file.WriteLine(text);
                }

            }
            // Heap Sort -------------------------------------------------------------
            Console.WriteLine("Heap sort");
            //Uncomment out which type of data you want
            arrayHS = random(SIZE);
            //arrayHS = reverse(SIZE);
            //arrayHS = fewUnique(SIZE);
            //arrayHS = almostSorted(SIZE);

       /*     Console.WriteLine("\nHeap before: ");
            foreach (var item in arrayHS)
            {
                Console.Write(item.ToString() + " ");
            } */

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Sort.txt", true))                                     // CHANGE THIS FILE LOCATION TO MATCH YOUR TEXT FILE
            {
                file.WriteLine("Heap Sort  " + "Data Size: " + SIZE);
            }

            for (int r = 0; r < 10; r++)
            {

                Stopwatch sw5 = new Stopwatch();
                sw5.Start();
                heapsort(arrayHS);
                sw5.Stop();
                long timeheap = sw5.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
                double timeheapsec = (timeheap * .000001);

                /*      Console.WriteLine("\nHeap after: ");
                      foreach (var item in arrayHS)
                      {
                          Console.Write(item.ToString() + " ");
                      } */

                Console.WriteLine("\nRun: {0} Heap sort: {1} microseconds and {2} seconds", r, timeheap, timeheapsec);

                double text = timeheapsec;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Sort.txt", true))                                     // CHANGE THIS FILE LOCATION TO MATCH YOUR TEXT FILE
                {
                    file.WriteLine(text);
                }

            }
            Console.ReadKey();
        } //main

        static void swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        // ------bubblesort------------------------------------------------------------------------------------------------------
        static void bubblesort(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1-i; j++)
                {
                    if (arr[j] > arr[j+1])
                        swap(ref arr[j], ref arr[j+1]);
                }
            }
        }
        // ------selectionsort---------------------------------------------------------------------------------------------------
        static void selectionsort(int[] arr, int size)
        {
            int min, i, j;
            for (i = 0; i < size; i++)
            {
                min = i;
                for (j = i + 1; j < size; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                swap(ref arr[i], ref arr[min]);
            }
        }
        // ------mergesort-------------------------------------------------------------------------------------------------------
        static void mergesort(int[] arr, int l, int r)
        {
            int mid;

            if (l < r)
            {
                mid = (l + r) / 2;
                mergesort(arr, l, mid);
                mergesort(arr, mid + 1, r);
                merge(arr, l, mid, r);
            }
        }
        static void merge(int[] arr, int l, int mid, int r)
        {
            int[] temp = new int[arr.Length];
            int x, i, j, k;

            i = l;
            j = mid +1;
            k = l;

            while (i <= mid && j <= r)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }
                k++;
            }

            if (i > mid) {
                for (x = j; x <= r; x++)
                    temp[k++] = arr[x];
            }
            else{
                for (x = i; x <= mid; x++)
                    temp[k++] = arr[x];
            }
            for (x = l; x <= r; x++)
                arr[x] = temp[x];
            
        }
        // ------quicksort-------------------------------------------------------------------------------------------------------
        static void quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                    i++;
               
                while (elements[j].CompareTo(pivot) > 0)
                    j--;

                if (i <= j)
                {
                    swap(ref elements[i], ref elements[j]);

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
                quicksort(elements, left, j);
            
            if (i < right)
                quicksort(elements, i, right);
            
        }
        // ------heapsort--------------------------------------------------------------------------------------------------------
        static void heapsort(int[] input)
        {
            //Build Max Heap
            int heapSize = input.Length;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                MaxHeapify(input, heapSize, p);
            
            for (int i = input.Length - 1; i > 0; i--)
            {
                swap(ref input[i], ref input[0]);

                heapSize--;
                MaxHeapify(input, heapSize, 0);
            }
        }

	    static void MaxHeapify(int[] input, int heapSize, int index)
	    {
		    int left = (index + 1) * 2 - 1;
		    int right = (index + 1) * 2;
		    int largest = 0;

		    if(left < heapSize && input[left] > input[index])
			    largest = left;
		    else
		        largest = index;
		    
		    if(right < heapSize && input[right] > input[largest])
			    largest = right;
		    
		    if(largest != index)
		    {
                swap(ref input[index], ref input[largest]);
			    MaxHeapify(input, heapSize, largest);
		    }
	    }



        static int[] reverse(int size)
        {
            int[] reversedArr = new int[size];

            Random rnd = new Random();
            for (int i = 0; i < size; i++)
                reversedArr[i] = rnd.Next(1, 10000);

            Array.Sort(reversedArr);
            Array.Reverse(reversedArr);
            return reversedArr;
        }

        static int[] almostSorted(int size)
        {
            int[] almostSortedArr = new int[size];

            Random rnd = new Random();
            for (int i = 0; i < size; i++)
                almostSortedArr[i] = rnd.Next(1, 10000);

            Array.Sort(almostSortedArr);

            int p = (int)(size * .20); //change last 20%
            int s = size - p;
            for (int i = s; i < size; i++)
                almostSortedArr[i] = rnd.Next(1, 10000);

            return almostSortedArr;
        }

        static int[] fewUnique(int size)
        {
            int[] fewUniqueArr = new int[size];

            Random rnd = new Random();
            int same = rnd.Next(1, 10000);
            for (int i = 0; i < size; i++)
                fewUniqueArr[i] = same;

            Array.Sort(fewUniqueArr);

            int p = (int)(size * .20);   //change 20% of values
            for (int i = 0; i < p; i++)
                fewUniqueArr[rnd.Next(1, 10000) % size] = rnd.Next(1, 10000);

            return fewUniqueArr;
        }

        static int[] random(int size)
        {
            int[] randomNum = new int[size];
            
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
                randomNum[i] = rnd.Next(1, 10000);

            return randomNum;
        }



    } //class
} //namespace
