namespace SortAlg.Algorithms;

public class SelectionSort
{
    public static void MainSort()
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Given Array");
        PrintArray(arr);
        SelectionSort ob = new SelectionSort();
        ob.Sort(arr);
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
    
    public void Sort(int[] list)
    {
        var position = 0;

        while (position < (list.Length - 1))
        {
            var lowestPosition = position;

            for (int i = position; i < list.Length; i++)
            {
                if (list[i] < list[lowestPosition])
                {
                    lowestPosition = i;
                }
            }

            var aux = list[position];
            list[position] = list[lowestPosition];
            list[lowestPosition] = aux;

            position++;
        }
    }
}