//              Задача:
//   Напишите программу, которая на вход принимает позиции элемента 
//   в двумерном массиве, и возвращает значение этого элемента или 
//   же указание, что такого элемента нет.
//             Программа:


int[,] arrayNumbs = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

int GetNumberInArray (int indexA, int indexB)
{
    if (indexA <= 2 && indexB <= 3)
    {
        return arrayNumbs[indexA,indexB];
    }
    else
    {
        return -1;
    }
}


Console.Write("введите индекс столбца - ");
int indexA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите индекс строки - ");
int indexB = Convert.ToInt32(Console.ReadLine());
Console.Write($"число по заданию - ({GetNumberInArray(indexA, indexB)})\n");

