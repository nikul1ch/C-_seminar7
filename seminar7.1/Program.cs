double[,] CreateMatrix(int rowCount, int columnCount, int max, int min)
{
    double[,] matrix = new double[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            matrix[row, column] = Math.Round(new Random().NextDouble() * (max - min) + min, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        Console.Write($"|\t");
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{matrix[row, column]}\t");
        }
        Console.Write("|");
        Console.WriteLine();
    }

}

int InputVariable()
{
    return Convert.ToInt32(Console.ReadLine());
}


Console.Write($"Введите количество строк: ");
int rowCount = InputVariable();
Console.Write($"Введите количество столбцов: ");
int columnCount = InputVariable();
Console.Write($"Введите минимальную грацицу диапазона чисел: ");
int min = InputVariable();
Console.Write($"Введите максимальную грацицу диапазона чисел: ");
int max = InputVariable();

double[,] matrix = CreateMatrix(rowCount, columnCount, min, max);
PrintMatrix(matrix);