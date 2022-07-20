namespace SortAlg.Algorithms;

public class InsertionSort
{
    public static void MainSort()
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Given Array");
        PrintArray(arr);
        InsertionSort ob = new InsertionSort();
        ob.RecursiveSort(arr, arr.Length);
        Console.WriteLine("\nSorted array ");
        PrintArray(arr);
    }
    
    private static void PrintArray(int[] list)
    { 
        
        for (int i = 0; i < list.Length; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
    
    private void Sort(int[] list)
    {
        for (int i = 1; i < list.Length; i++)
        {
            var key = list[i];
            var j = i - 1;

            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = key;
        }
    }

    private void RecursiveSort(int[] list, int n)
    {
        if (n <= 1)
        {
            return;
        }
        
        RecursiveSort(list, n -1);

        var key = list[n - 1];
        var counter = n - 2;

        while (counter >= 0 && list[counter] > key)
        {
            list[counter + 1] = list[counter];
            counter--;
        }

        list[counter + 1] = key;
    }
}