double[,] CreateMatrix(int rowCount, int columnCount)
{
    double[,] matrix = new double[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            matrix[row, column] = Math.Round(new Random().NextDouble() * 10, 1);
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

void ReturnValue(int row, int column, double[,] matrix)
{
    if (row < 0 || row > matrix.GetLength(0) - 1 || column < 0 || column > matrix.GetLength(1) - 1) Console.Write($"Элемента с индексом [{row},{column}] в массиве нет!");
    else Console.Write($"Элемент с индексом [{row},{column}] = {matrix[row, column]}");
}

int InputVariable()
{
    return Convert.ToInt32(Console.ReadLine());
}

Console.Write($"Введите количество строк: ");
int rowCount = InputVariable();
Console.Write($"Введите количество столбцов: ");
int columnCount = InputVariable();
Console.Write($"Введите номер строки искомого значения: ");
int rowNumber = InputVariable();
Console.Write($"Введите номер столбца искомого значения: ");
int columnNumber = InputVariable();

double[,] matrix = CreateMatrix(rowCount, columnCount);
PrintMatrix(matrix);
Console.WriteLine();
ReturnValue(rowNumber, columnNumber, matrix);