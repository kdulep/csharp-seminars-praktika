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

void Print_Recursive(int n, int m){
    Console.Write(n+ " ");
    if(n == m) return;
    else {
        Print_Recursive(n+1, m);
        }
    

}

int n = InputNumber("Input N:");
int m = InputNumber("Input M:");
Console.WriteLine("\n===================\n");
Print_Recursive(n,m);
