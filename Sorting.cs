public static class Sorting
{
    public static int[] SortSelectionArray(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = array[i];
            int max = default;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[i])
                {
                    min = array[j];
                    max = array[i];
                    array[i] = min;
                    array[j] = max;
                }
            }
        }
        return array;
    }
}