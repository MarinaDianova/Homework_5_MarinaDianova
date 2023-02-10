// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[] GenerateArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        //array[i] = rand.Next(leftRange, rightRange) + Math.Round(rand.NextDouble(), 2, MidpointRounding.ToEven);
        array[i] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("; ", array) + "]");
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int size = GetNumber("Введите размер массива: ");
int min = GetNumber("Введите левую границу генерации чисел: ");
int max = GetNumber("Введите правую границу генерации чисел: ");

double[] myArray = GenerateArray(size, min, max);
PrintArray(myArray);
System.Console.WriteLine();
System.Console.WriteLine($"Максимальный элемент массива: {FindMax(myArray)}");
System.Console.WriteLine($"Минимальный элемент массива: {FindMin(myArray)}");
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Math.Round((FindMax(myArray) - FindMin(myArray)), 2, MidpointRounding.ToEven)}");
System.Console.WriteLine();