public static class CreateIntArray
{
    public static int[] CreateArray(int num)
    {
        int[] array = new int[num];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите {i + 1} элемент массива: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
}