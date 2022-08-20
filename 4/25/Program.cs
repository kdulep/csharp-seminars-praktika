int Exponential(int numberA, int numberB)
{
    int exp = 1;
    for (int i = 0; i < numberB; i++)
    {
        exp = exp * numberA;
    }
    return exp;
};

int number = 0;
int numberA, numberB;
Console.WriteLine("Input A:");
numberA = int.TryParse(Console.ReadLine(), out number) ? number : 0;

Console.WriteLine("Input B:");
numberB = int.TryParse(Console.ReadLine(), out number) ? number : 0;

Console.WriteLine("Result :" + Exponential(numberA, numberB));