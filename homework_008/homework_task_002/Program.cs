//         задача:
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
//       программа:

int[,] GetFillArrayNumbers (int columns, int rows)
{
    int[,] fillArrayNumbers = new int[columns, rows];
    for (int i = 0; i < fillArrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < fillArrayNumbers.GetLength(1); j++)
        {
            fillArrayNumbers[i, j] = new Random().Next(0, 20);
        }
    }
    return fillArrayNumbers;
}

int GetMinSummaArrayNumbers (int[,] fillArrayNumbers)
{
    int summaNumbers = 0;
    int minSummaNumbers = 0;
    int rowsMinSummaNumbers = -1;
    for (int j = 0, i = 0; j < fillArrayNumbers.GetLength(1); j++)
        {
            summaNumbers += fillArrayNumbers[i, j];
            minSummaNumbers = summaNumbers;
        }
    summaNumbers=0;
    for (int i = 0; i < fillArrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < fillArrayNumbers.GetLength(1); j++)
        {
            summaNumbers += fillArrayNumbers[i, j];
        }
        if (minSummaNumbers > summaNumbers) 
        {
            minSummaNumbers = summaNumbers;
            rowsMinSummaNumbers = i;
        }
        summaNumbers=0;
    }
    return rowsMinSummaNumbers;
}

void Print (int[,] fillArrayNumbers)
{
    int columns = fillArrayNumbers.GetLength(0);
    int rows = fillArrayNumbers.GetLength(1);
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write($"{fillArrayNumbers[i, j]:d3} ");
        }
        Console.WriteLine();
    }
}

Console.Write("введите количество столбцов двумерного массива - ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество строк двумерного массива - ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] fillArray = GetFillArrayNumbers(columns, rows);
Console.WriteLine();
Print(fillArray);
Console.WriteLine();
Console.WriteLine($"индекс строки с минимальной суммой - {GetMinSummaArrayNumbers(fillArray)}");
