//       Задача:
// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
//      Программа:

int[,] GetFillArrayNumbers (int lengthArray)
{
    int[,] fillArrayNumbers = new int[lengthArray, lengthArray];
    for (int i = 0; i < fillArrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < fillArrayNumbers.GetLength(1); j++)
        {
            fillArrayNumbers[i, j] = new Random().Next(1, 5);
        }
    }
    return fillArrayNumbers;
}

int[,] GetProizvedFillArrayNumbers (int[,] fillArrayNumbers1, int[,] fillArrayNumbers2)
{
    int[,] proizvedFillArrayNumbers = new int[fillArrayNumbers1.GetLength(1), fillArrayNumbers2.GetLength(0)];
    int summaNumbers = 0;
    for (int i = 0; i < proizvedFillArrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < proizvedFillArrayNumbers.GetLength(1); j++)
        {
            for (int k = 0; k < fillArrayNumbers1.GetLength(0); k++)
            {
                summaNumbers += fillArrayNumbers1[i, k] * fillArrayNumbers2[k,j];
            }
            proizvedFillArrayNumbers[i, j] = summaNumbers;
            summaNumbers = 0;
        }
    }
    return proizvedFillArrayNumbers;
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



Console.Write("введите размерность двумерного массива - ");
int lengthArray = Convert.ToInt32(Console.ReadLine());
int[,] fillArray1 = GetFillArrayNumbers(lengthArray);
Console.WriteLine();
Print(fillArray1);
int[,] fillArray2 = GetFillArrayNumbers(lengthArray);
Console.WriteLine();
Print(fillArray2);
Console.WriteLine();
int[,] proizvedArray = GetProizvedFillArrayNumbers(fillArray1, fillArray2);
Print(proizvedArray);
