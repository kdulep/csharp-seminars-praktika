int number = 0;
do
{
    Console.WriteLine("Input number");
    number = int.TryParse(Console.ReadLine(), out number) ? number : 0;
} while (!(1 <= number && number <= 7));

switch (number)
{
    case 6:
    case 7:
        Console.WriteLine("Day is Weekend");
        break;

    default:
        Console.WriteLine("Day is Workday");
        break;
}