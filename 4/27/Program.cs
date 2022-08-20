
int sumNum(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

int number = 0;
int numberA;
Console.WriteLine("Input number:");
numberA = int.TryParse(Console.ReadLine(), out number) ? number : 0;

Console.WriteLine("Sum of digits:" + sumNum(numberA));