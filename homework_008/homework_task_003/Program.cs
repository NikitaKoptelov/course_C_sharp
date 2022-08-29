//         задача:
// Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2.
//       программа:

int[,,] GetFillArrayNumbers (int columns, int rows, int listArray)
{
    int[,,] fillArrayNumbers = new int[columns, rows, listArray];
    int numbers = 10;
    for (int i = 0; i < fillArrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < fillArrayNumbers.GetLength(1); j++)
        {
            for (int z = 0; z < fillArrayNumbers.GetLength(2); z++)
            {
                fillArrayNumbers[i, j, z] = numbers;
                numbers++;
            }
        }
    }
    return fillArrayNumbers;
}


void Print (int[,,] fillArrayNumbers)
{
    int columns = fillArrayNumbers.GetLength(0);
    int rows = fillArrayNumbers.GetLength(1);
    int listArray = fillArrayNumbers.GetLength(2);
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int z = 0; z < listArray; z++)
            {
                Console.Write($"{fillArrayNumbers[i, j, z]:d2}-({j},{z},{i})  ");
            }
            Console.WriteLine();
        }
        
    }
}

Console.Write("введите количество столбцов трехмерного массива - ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество строк трехмерного массива - ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество страниц трехмерного массива - ");
int listArray = Convert.ToInt32(Console.ReadLine());
int[,,] fillArray = GetFillArrayNumbers(columns, rows, listArray);
Console.WriteLine();
Print(fillArray);


