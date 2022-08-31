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

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0}\t", a[i, j]);
        }
        Console.WriteLine();
    }
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


int[,] Multiplication(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}

Console.WriteLine("\n===================\n");
int m = InputNumber("Input m1:");
int n = InputNumber("Input n1:");
Console.WriteLine("\n===================\n");
int[,] arrayA = new int[m, n];
FillArray(arrayA);
int m2 = InputNumber("Input m2:");
int n2 = InputNumber("Input n2:");

int[,] arrayB = new int[m2, n2];
FillArray(arrayB);
Console.WriteLine("MatrixA\n");
Print(arrayA);
Console.WriteLine("MatrixB\n");
Print(arrayB);
int[,] arrayC=Multiplication(arrayA, arrayB);
Console.WriteLine("Result:");
Print(arrayC);
Console.WriteLine("\n===================\n");