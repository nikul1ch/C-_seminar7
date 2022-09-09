double[,] CreateMatrix(int rowCount, int columnCount)
{
    double[,] array = new double[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = Math.Round(new Random().NextDouble() * 10, 1);
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        Console.Write($"|\t");
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]}\t");
        }
        Console.Write("|");
        Console.WriteLine();
    }

}

void ReturnValue(int row, int column, double[,] array)
{
    if (row < 0 || row > array.GetLength(0) - 1 || column < 0 || column > array.GetLength(1) - 1) Console.Write($"Элемента с индексом [{row},{column}] в массиве нет!");
    else Console.Write($"Элемент с индексом [{row},{column}] = {array[row, column]}");
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

double[,] array = CreateMatrix(rowCount, columnCount);
PrintMatrix(array);
Console.WriteLine();
ReturnValue(rowNumber, columnNumber, array);