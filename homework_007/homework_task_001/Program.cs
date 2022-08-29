//       Задача:
//   Показать двумерный массив размером m×n заполненный вещественными числами
//          Программа:


double GetArrayNumbs (int indsexA, int indexB)
{
    double[,] arrayNubs = new double[10, 10];
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            arrayNubs[i, j] = new Random().NextDouble() * 10;
        }
    }
    return arrayNubs[indsexA, indexB];
}



void PrintArrayNumbs ()
{
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            Console.Write($"{GetArrayNumbs(i, j):f3}  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("двумерный масив случайных чисел : ");
PrintArrayNumbs();

