package BubbleSort;

import java.util.Random;

public class BubbleSort
{
    int[] arr = new int[20];
    int temp=0;
    boolean is_sort=false;

    Random random = new Random();

    public void Assign()
    {
        for(int i=0;i<arr.length;i++)
        {
            arr[i]=random.nextInt(101);

        }


    }

    public void Sort()
    {
        for(int m=0;m<arr.length-1;m++)
        {
            is_sort=false;

            for(int n=0;n<arr.length-1;n++)
            {
                if(arr[n]<arr[n+1])
                {
                    is_sort=true;
                    temp=arr[n];
                    arr[n]=arr[n+1];
                    arr[n+1]=temp;
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
        for(int i=0;i<arr.length;i++)
        {
            System.out.println(arr[i]);
        }
    }

}

class Test
{
    public static void main(String[] args)
    {
        BubbleSort bubbleSort = new BubbleSort();
        bubbleSort.Assign();
        bubbleSort.Sort();
        bubbleSort.Show();

    }
}
