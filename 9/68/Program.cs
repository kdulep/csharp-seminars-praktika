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

int Recursive_Akker(int m, int n)
{
    if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
    if (m == 0) return n + 1;
    else
        if ((m != 0) && (n == 0)) { return Recursive_Akker(m - 1, 1); }
    else
    { return Recursive_Akker(m - 1, Recursive_Akker(m, n - 1)); }

}

int n = InputNumber("Input N:");
int m = InputNumber("Input M:");
Console.WriteLine("\n===================\n");
Console.WriteLine(Recursive_Akker(m, n));
