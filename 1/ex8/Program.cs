Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

Console.WriteLine("Even numbers");
while (count <= number)
{
    Console.WriteLine(count);
    count += 2;
}