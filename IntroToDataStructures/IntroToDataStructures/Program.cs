using System;
using System.Collections.Generic;

namespace IntroToDataStructures
{
    class Program
    {

        public static void BubbleSort(List<int> list)
        {
            bool isSorted = false;

            // adaptive optimization

            int count = 0;

            while (!isSorted)
            {
                isSorted = true;

                for (int i = 0; i < list.Count - 1 - count; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        isSorted = false;
                    }
                  
                }
                count++;

            }
        }

        static void Main(string[] args)
        {
            List<int> unsortedList = new List<int> { 6, 2, 1, 3, 5, 4 };

            // generate a list of length 10 of 10 random values from -10 to 15

            Random random = new Random();

            List<int> RandomList = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                RandomList.Add(random.Next(-10, 16));
            }


            // 2 1 3 5 4 6
            // 1 2 3 5 4 6
            // 1 2 3 4 5 6

            // 1 2 3 4 5 6
            // 1 2 3 4 5 6
            BubbleSort(RandomList);

            ;

            //Console.WriteLine("Hello World!");
        }
    }
}
