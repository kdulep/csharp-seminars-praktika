using System.Linq;

Console.WriteLine("Input numbers delimited by spaces: ");

int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
int maxValue = arr.Max();
//int minValue = arr.Min();

Console.WriteLine("max value: " + maxValue);