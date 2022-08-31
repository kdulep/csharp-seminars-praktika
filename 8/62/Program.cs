using System.Text;
Console.OutputEncoding = Encoding.UTF8;

int InputNumber(in string prompt)
{
    bool result;
    do
    {
        Console.WriteLine(prompt);
        string? input = Console.ReadLine();

        result = int.TryParse(input, out var number);
        if (result == true)
        {
            //Console.WriteLine($"Преобразование прошло успешно. Число: {number}");
            return number;
        }
        else
            Console.WriteLine("Преобразование завершилось неудачно");
    } while (result);
    return 0;
}

void FillArray(int[,] matrix, int n)
{
    int row = 0;
    int col = 0;
    string direction = "right";
    int maxRotations = n * n;

    for (int i = 1; i <= maxRotations; i++)
    {
        if ((direction == "right") && (col > n - 1 || matrix[row, col] != 0))
        {
            direction = "down";
            col--;
            row++;
        }
        if ((direction == "down") && (row > n - 1 || matrix[row, col] != 0))
        {
            direction = "left";
            row--;
            col--;
        }
        if ((direction == "left") && (col < 0 || matrix[row, col] != 0))
        {
            direction = "up";
            col++;
            row--;
        }
        if ((direction == "up") && (row < 0 || matrix[row, col] != 0))
        {
            direction = "right";
            row++;
            col++;
        }
        matrix[row, col] = i;
        if (direction == "right")
        {
            col++;
        }
        if (direction == "down")
        {
            row++;
        }
        if (direction == "left")
        {
            col--;
        }
        if (direction == "up")
        {
            row--;
        }
    }
}

void PrintMatrix(int[,] matrix, int n)
{
    for (int r = 0; r < n; r++)
    {
        for (int c = 0; c < n; c++)
        {
            Console.Write("{0, 4}", matrix[r, c]);
        }
        Console.WriteLine();
    }
}
Console.WriteLine("\n===================\n");
int n = InputNumber("Input N:");
int[,] matrix = new int[n, n];
FillArray(matrix,n);
PrintMatrix(matrix,n);
