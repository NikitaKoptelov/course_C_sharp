//          Задача:
//   Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
//          Программма:


int[,] arrayNumbs = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};


void GetNewArrayNumbs()
{
    int summaNumbs = 0;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            summaNumbs += arrayNumbs[j, i];
        }
        Console.WriteLine($"среднеарифметическое столбца {i} - {summaNumbs / 3}");
        summaNumbs = 0;
    }
}



GetNewArrayNumbs();

