﻿int number = 0;
do
{
    Console.WriteLine("Input 3 digit number");
    number = int.TryParse(Console.ReadLine(), out number) ? number : 0;
} while (number < 100 || number > 999);

string numberstr = number.ToString("D3");
Console.WriteLine("middle number " + numberstr[1]);

