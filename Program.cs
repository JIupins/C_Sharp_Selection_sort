using static Sorting;
using static CreateIntArray;
using static ArrayShow;

Console.Clear();

Console.WriteLine($"Ведиче колличество элементов в массиве: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] mainArray = CreateArray(count);

ShowArray(mainArray);

mainArray = SortSelectionArray(mainArray);

ShowArray(mainArray);