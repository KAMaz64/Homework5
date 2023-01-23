/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();
int[] GenerateArray(int length, int min, int max)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}

int DifferenceMinMax(int[] array)
{
    int diff = 0;
    int min = array[0];
    int max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    diff = max - min;
    return diff;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива");
int Size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите мин.значение массива");
int Min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите макс.значение массива");
int Max = Convert.ToInt32(Console.ReadLine());

int[] newArray = GenerateArray(Size, Min, Max);

ShowArray(newArray);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {DifferenceMinMax(newArray)}");
