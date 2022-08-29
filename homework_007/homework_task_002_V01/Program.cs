//              Задача:
//   В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
//             Программа:


int[,] arrayNumbs = {
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
    {2, 4, 6, 7, 9, 1, 3, 5, 7, 1},
};


string GetNewArrayNumbs(int serchNub)
{
    string serchNubString = string.Empty;
    int count = 0, countNumbers = 0;
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {

            if (arrayNumbs[i, j] == serchNub)
            {
                serchNubString += $"{serchNub} - X ({j}), Y ({i}).\n";
                count++;
                countNumbers++;
            }
        }
    }
    if (count == 0)
    {
        serchNubString += $"{serchNub} - нету.\n";
    }
    serchNubString += $"колличество найденых - {countNumbers}\n";
    return serchNubString;
}


Console.Write("ыыедите искомое число - ");
int serchNub = Convert.ToInt32(Console.ReadLine());
Console.Write(GetNewArrayNumbs(serchNub));

