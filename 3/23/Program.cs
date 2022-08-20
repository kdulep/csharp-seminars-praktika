static int getnumber()
{
    int number = 0;
    do
    {
        Console.WriteLine("Input N");
        number = int.TryParse(Console.ReadLine(), out number) ? number : 0;
    } while (number <= 0);
    return number;
}

int n = getnumber();
Console.WriteLine("================================================================");
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i * i * i);
};