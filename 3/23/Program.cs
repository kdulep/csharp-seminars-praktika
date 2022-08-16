int number = 0;
do
{
    Console.WriteLine("Input N");
    number = int.TryParse(Console.ReadLine(), out number) ? number : 0;
} while (number<=0);

Console.WriteLine("================================================================");
for(int i=1;i<=number;i++){
    Console.WriteLine(i*i*i);
};