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

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }

        }
    }
    return;
}

void Print(int[,,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {

            for (int k = 0; k < a.GetLength(2); k++)
            {
                Console.Write("{0}", a[i, j, k]);
                Console.Write("({0},{1},{2}) ", i, j, k);
            }
            Console.WriteLine();
        }
        
    }
}

Console.WriteLine("\n======================================\n");

int m = InputNumber("Input m:");
int n = InputNumber("Input n:");
int o = InputNumber("Input o:");
Console.WriteLine("\n======================================\n");
int[,,] array = new int[m, n, o];
Console.WriteLine("Исходный массив:");
FillArray(array);
Print(array);
