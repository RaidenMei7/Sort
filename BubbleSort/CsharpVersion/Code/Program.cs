using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Assign();
            bubbleSort.Sort();
            bubbleSort.Show();

        }
    }


    //2022.4.10
    //Maybe is time to recall the Animation Carole&Tuesday? www
    class BubbleSort
    {
        int[] arr = new int[20];
        int temp;
        bool is_sort;

        Random r = new Random();

        public void Assign()
        {
            for(int i = 0; i< arr.Length; i++)
            {
                arr[i] = r.Next(101);
            }

        }

        public void Sort()
        {
            for(int m = 0; m<arr.Length-1;m++)
            {
                is_sort = false;

                for(int n = 0;n<arr.Length - 1 - m;n++)
                {
                    if(arr[n]>arr[n+1])
                    {
                        is_sort = true;

                        temp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = temp;
                    }

                }

                if(!is_sort)
                {
                    break;
                }


            }

        }

        public void Show()
        {
            for(int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }



    }
}

