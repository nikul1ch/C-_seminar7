int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            matrix[row, column] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

double[] AverageColumn(int[,] matrix)
{
    double sum = 0;
    double[] array = new double[matrix.GetLength(1)];
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            sum += matrix[row, column];
        }
        array[column] = sum / matrix.GetLength(0);
        sum = 0;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write(array[i]);
        else Console.Write(array[i] + " ; ");
    }
    Console.WriteLine(" ]");
}

Console.Write($"Введите количество строк: ");
int rowCount = InputVariable();
Console.Write($"Введите количество столбцов: ");
int columnCount = InputVariable();

int[,] matrix = CreateMatrix(rowCount, columnCount);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое элементов каждого столбца");
PrintArray(AverageColumn(matrix));