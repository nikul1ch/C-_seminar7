double[,] CreateMatrix(int rowCount, int columnCount, int max, int min)
{
    double[,] array = new double[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = Math.Round(new Random().NextDouble() * (max - min) + min, 1);
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

double[,] array = CreateMatrix(rowCount, columnCount, min, max);
PrintMatrix(array);