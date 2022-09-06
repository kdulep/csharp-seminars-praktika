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

int sum_rec(int m, int n){

return m == n ? n : m + sum_rec(m-1,n);
}

int n = InputNumber("Input N:");
int m = InputNumber("Input M:");
Console.WriteLine("\n===================\n");
Console.WriteLine(sum_rec(m,n));
