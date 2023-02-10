// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int SumChetPosition(int[] array)
{
    int SumChetPosition = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (j % 2 == 1)
        {
            SumChetPosition += array[j];
        }
    }
    return SumChetPosition;
}

int size = GetNumber("Введите размер массива: ");
int min = GetNumber("Введите левую границу генерации чисел: ");
int max = GetNumber("Введите правую границу генерации чисел: ");
int[] myArray = GenerateArray(size, min, max);
PrintArray(myArray);

System.Console.WriteLine($"Сумма элементов, стоящих на чётных позициях массива равна {SumChetPosition(myArray)}");