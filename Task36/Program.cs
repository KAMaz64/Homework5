// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях[3, 7, 23, 12] -> 19

int[] GenerateArray(int length, int min, int max)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}

int SumOfOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum+= array[i];
    }
    return sum;
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

Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {SumOfOddElements(newArray)}");
