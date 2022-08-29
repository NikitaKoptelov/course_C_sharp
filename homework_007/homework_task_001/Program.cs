//       Задача:
//   Показать двумерный массив размером m×n заполненный вещественными числами
//          Программа:


double[,] GetFillArrayNumbers (int columns, int rows)
{
    double[,] fillArrayNumbers = new double[columns, rows];
    for (int i = 0; i < fillArrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < fillArrayNumbers.GetLength(1); j++)
        {
            fillArrayNumbers[i, j] = new Random().NextDouble() * 10;
        }
    }
    return fillArrayNumbers;
}



void Print (double[,] fillArrayNumbers)
{
    int columns = fillArrayNumbers.GetLength(0);
    int rows = fillArrayNumbers.GetLength(1);
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write($"{fillArrayNumbers[i, j]:f3} ");
        }
        Console.WriteLine();
    }
}


Console.Write("введите количество столбцов двумерного массива - ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество строк двумерного массива - ");
int rows = Convert.ToInt32(Console.ReadLine());
double[,] fillArray = GetFillArrayNumbers(columns, rows);
Console.WriteLine();
Console.WriteLine("двумерный масив случайных чисел : ");
Print(fillArray);

