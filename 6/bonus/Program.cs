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
            array[i, j] = new Random().Next(-10, 11);
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

int SumOfElements(int[,] array)
{
    int index = 0, sum = 0;
    do
    {
        sum += array[index, index];
        index++;
    } while (index < array.GetLength(0) && index < array.GetLength(1));
    return sum;
}
Console.WriteLine("===================\n");
int m = InputNumber("Input m:");
int n = InputNumber("Input n:");
Console.WriteLine("===================\n");
int[,] array =new int[m, n];
FillArray(array);
PrintArray(array);
//int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
Console.WriteLine();
Console.WriteLine($"Sum of main matrix diagonal: {SumOfElements(array)}");