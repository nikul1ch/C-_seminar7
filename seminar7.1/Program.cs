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

// int InputVariable(int var)                           Хотел вынести считывание из консоли в метод
// {                                                    В консоли пытался вывести имя переменной, чтобы пользователь понимал какую переменную он заполняет
//     Console.Write($"Введите {"var"}: ");             Но ничего не вышло, решил оставить ввод консоли без метода)  
//     return Convert.ToInt32(Console.ReadLine());      При проверке предыдущих ДЗ вы писали что лучше вынести в метод (3 и 4 дз), но чем лучше не понял
// }

//int rowCount = InputVariable(rowCount = 0);           
//int columnCount = InputVariable(columnCount = 0);
//double min = InputVariable(min = 0);
//double max = InputVariable(max = 0);

Console.Write($"Введите количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите количество столбцов: ");
int columnCount = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите минимальную грацицу диапазона чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите максимальную грацицу диапазона чисел: ");
int max = Convert.ToInt32(Console.ReadLine());


double[,] array = CreateMatrix(rowCount, columnCount, min, max);
PrintMatrix(array);