


public static class InsertionSort
{

    public static void Sort<T>(T[] array) where T : IComparable
    {

        for (int i = 0; i < array.Length; i++)
        {

            int j = i;
            while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
            {

                Swap(array, j, j - 1);
                j--;

            }
        }


    }


    public static void Swap<T>(T[] array, int first, int second)
    {

        (array[first], array[second]) = (array[second], array[first]);

    }

}