
int[] InputNumbers()
{
    Console.WriteLine("Input numbers delimited by spaces:");
    string sNumbers = Console.ReadLine();
    return sNumbers?.Split(' ')?.Select(Int32.Parse)?.ToArray();
}

int CountPositives(int[] InputNumbers)
{
    int count = 0;

    foreach (var item in InputNumbers)
    {
        if (item > 0) { count++; }
    }
    return count;
}

int[] arr = InputNumbers();
Console.WriteLine($"Count of positives {CountPositives(arr)}");