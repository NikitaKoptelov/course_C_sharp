﻿//          Задача:
//   Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
//          Программма:


int[,] arrayNumbs = {
    {7, 4, 6, 7, 9, 1, 7, 3, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {5, 5, 6, 7, 9, 1, 3, 3, 4, 6},
    {2, 9, 6, 7, 9, 1, 9, 3, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 4, 1},
    {2, 7, 5, 7, 9, 1, 3, 3, 7, 6},
    {4, 8, 6, 7, 9, 1, 7, 5, 7, 1},
    {2, 4, 6, 7, 5, 1, 3, 5, 4, 1},
    {7, 4, 8, 7, 9, 1, 9, 3, 7, 6},
    {2, 9, 6, 7, 9, 1, 3, 5, 7, 1},
};


void GetNewArrayNumbs()
{
    int summaNumbs = 0;
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            summaNumbs += arrayNumbs[j, i];
        }
        Console.WriteLine($"среднеарифметическое столбца {i} - {summaNumbs / 10}");
        summaNumbs = 0;
    }
}



GetNewArrayNumbs();

