//         задача:
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
//       программа:

int[,] GetFillArrayNumbers (int lengthArray)
{
    int[,] fillArrayNumbers = new int[lengthArray, lengthArray];
    for (int i = 0; i < fillArrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < fillArrayNumbers.GetLength(1); j++)
        {
            fillArrayNumbers[i, j] = new Random().Next(0, 20);
        }
    }
    return fillArrayNumbers;
}

int[,] GetSortArrayNumbers (int[,] fillArrayNumbers)
{
    int temp = 0;
    for (int i = 0; i < fillArrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < fillArrayNumbers.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < fillArrayNumbers.GetLength(1); k++)
            {
                if(fillArrayNumbers[i, j] < fillArrayNumbers[i, k])
                {
                    temp = fillArrayNumbers[i, j];
                    fillArrayNumbers[i, j] = fillArrayNumbers[i, k];
                    fillArrayNumbers[i, k] = temp;
                }
                
            }
        }
    }
    return fillArrayNumbers;
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
int[,] fillArray = GetFillArrayNumbers(lengthArray);
Console.WriteLine();
Print(fillArray);
int[,] sortArray = GetSortArrayNumbers(fillArray);
Console.WriteLine();
Print(sortArray);
