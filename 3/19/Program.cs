static bool IsPalindrom(string str)
{
    for (int i = 0; i < str.Length; i++)
        if (str[i] != str[str.Length - i - 1]) return false;
    return true;
}

int number = 0;
do
{
    Console.WriteLine("Input 5 digit integer number");
    number = int.TryParse(Console.ReadLine(), out number) ? number : 0;
} while (number.ToString().Length != 5);

if(IsPalindrom(number.ToString())) Console.WriteLine("number is palindrom");
else Console.WriteLine("number is not palindrom");





