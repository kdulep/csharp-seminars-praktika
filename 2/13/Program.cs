int number = 0;
do
{
    Console.WriteLine("Input number");
    number = int.TryParse(Console.ReadLine(), out number) ? number : 0;
} while (number == 0);

string numberstr = number.ToString();
if (numberstr.Length > 2)
{
    Console.WriteLine("3rd digit number " + numberstr[2].ToString());
}
else
{
    Console.WriteLine("number less than 3 digits");
}