namespace SortAlg.Algorithms;

public class MergeSort
{
    public static void MainSort()
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Given Array");
        PrintArray(arr);
        MergeSort ob = new MergeSort();
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

    private void Sort(int[] list, int initialPosition = 0, int finalPosition = default) {
        if (finalPosition == default)
        {
            finalPosition = list.Length;
        }
        
        if (finalPosition - initialPosition > 1)
        {
            var midPosition = (initialPosition + finalPosition) / 2;
            Sort(list, initialPosition, midPosition);
            Sort(list, midPosition + 1, finalPosition);
            Merge(list, initialPosition, midPosition, finalPosition);
        }
    }
    
    private void Merge(int[] list, int initialPosition, int midPosition, int finalPosition)
    {
        var n1 = midPosition - initialPosition;
        var n2 = finalPosition - midPosition;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
        {
            leftArray[i] = list[initialPosition + i];
        }

        for (int j = 0; j < n2; j++)
        {
            rightArray[j] = list[midPosition + j];
        }

        var leftPosition = 0;
        var rightPosition = 0;

        for (int k = initialPosition; k < finalPosition; k++)
        {
            if (leftPosition < n1 && rightPosition < n2)
            {
                if (leftArray[leftPosition] < rightArray[rightPosition])
                {
                    list[k] = leftArray[leftPosition];
                    leftPosition++;
                }
                else
                {
                    list[k] = rightArray[rightPosition];
                    rightPosition++;
                }
            }
            else
            {
                if (leftPosition >= n1)
                {
                    list[k] = rightArray[rightPosition];
                    rightPosition++;
                }
                else
                {
                    list[k] = leftArray[leftPosition];
                    leftPosition++;
                }
            }
        }
    }
}