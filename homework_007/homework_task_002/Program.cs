//              Задача:
//   Напишите программу, которая на вход принимает позиции элемента 
//   в двумерном массиве, и возвращает значение этого элемента или 
//   же указание, что такого элемента нет.
//             Программа:


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

Tuple<int, string> GetNumberInArray (int[,] fillArrayNumbers, int columns, int rows)
{
    var numb = 0;
    var text = "good";
    if (columns <= fillArrayNumbers.GetLength(0) && rows <= fillArrayNumbers.GetLength(1))
    {
        numb = fillArrayNumbers[columns,rows];
    }
    else
    {
        text = "error";
    }
    var res = Tuple.Create(numb, text);
    return res;
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
Console.Write("введите столбец искомого числа - ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("введите строку искомого числа - ");
int rows = Convert.ToInt32(Console.ReadLine());
var numberInArray = GetNumberInArray(fillArray, columns, rows);
Console.WriteLine(numberInArray);
