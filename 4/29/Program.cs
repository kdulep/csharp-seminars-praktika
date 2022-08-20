
int[] returnNumbers(string x)
{
    Console.WriteLine("Input integers delimited by spaces: ");
    return x.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
}

void printNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i].ToString()+" ");
    }

}

int[] numbers;
do
{
    Console.WriteLine("Input 8 integers delimited by spaces: ");
    numbers = returnNumbers(Console.ReadLine());
    if (numbers.Length != 8)
    {
        Console.WriteLine("Wrong count of numbers");
    };
} while (numbers.Length != 8);

printNumbers(numbers);