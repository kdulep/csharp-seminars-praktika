using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int InputNumber(in string prompt)
{
    bool result;
    do
    {
        Console.WriteLine(prompt);
        string? input = Console.ReadLine();

        result = int.TryParse(input, out var number);
        if (result == true)
        {
            //Console.WriteLine($"Преобразование прошло успешно. Число: {number}");
            return number;
        }
        else
            Console.WriteLine("Преобразование завершилось неудачно");
    } while (result);
    return 0;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }

    }
    return;
}

int CheckMinSumArray(int[,] array)
{
    int minSum = 0;
    int indexMinSum = 0;

    minSum = Enumerable.Range(0, array.GetLength(1))
                .Select(x => array[indexMinSum, x])
                .ToArray().Sum();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = Enumerable.Range(0, array.GetLength(1))
                    .Select(x => array[i, x])
                    .ToArray().Sum();

        if (sum < minSum) { minSum = sum; indexMinSum = i; }
    }
    return indexMinSum;
}

int m = InputNumber("Input m:");
int n = InputNumber("Input n:");
Console.WriteLine("\n======================================\n");
Console.WriteLine("Исходный массив:");
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
int minIndex=CheckMinSumArray(array);
int[] minArray = Enumerable.Range(0, array.GetLength(1)).Select(x => array[minIndex, x]).ToArray();
Console.WriteLine("\n======================================\n");
Console.WriteLine($"Индекс наименьшей суммы элементов: {minIndex}, Сумма: {minArray.Sum()}");
Console.WriteLine("Строка: [{0}]", string.Join(", ", minArray));
//PrintArray(array);
Console.WriteLine("\n======================================\n");
