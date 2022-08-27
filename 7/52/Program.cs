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

double[] SAROfColumns(int[,] array)
{
    double[] b = new double[array.GetLength(1)];
    for (int i = 0, k = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        b[k] = (double)Math.Round(sum / array.GetLength(0), 2);
        k++;
    }

    return b;
}

Console.WriteLine("===================\n");
int m = InputNumber("Input m:");
int n = InputNumber("Input n:");
Console.WriteLine("===================\n");
int[,] array = new int[m, n];
FillArray(array);
//int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintArray(array);
Console.WriteLine("===================\n");
Console.WriteLine("SAR of columns: [{0}]", string.Join(", ", SAROfColumns(array)));