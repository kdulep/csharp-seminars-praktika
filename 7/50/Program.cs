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

bool PrintElementIndexes(int[,] array, in int number)
{
    //var list = new List<int[]>();
    bool found = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine($"Number {number} found at:[{i}:{j}]");
                found = true;
                //list.Add(new[] { i, j });
            }
        }
    }
    return found;
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

Console.WriteLine("===================\n");
int m = InputNumber("Input m:");
int n = InputNumber("Input n:");
int number = InputNumber("Input search number:");
Console.WriteLine("===================\n");
int[,] array = new int[m, n];

//int[,] array={{1,4,7,2},{5,9,2,3},{8,4,2,4}};
//int number=7;

FillArray(array);
PrintArray(array);
Console.WriteLine("\n===================\n");
if (PrintElementIndexes(array, number) == false) { Console.WriteLine("Not found"); }