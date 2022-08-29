//      Задача:
// Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//      Программа:


string GetNechetNub()
{
    int[] nubArray = new int[50];
    int sumNechetNub = 0;
    for (int i = 0; i < nubArray.Length; i++)
    {
        nubArray[i] = new Random().Next(1, 999);
        if (i % 2 != 0)
        {
            sumNechetNub += nubArray[i];
        }
    }
    return $"сумма чисел нечетных индексов в массиве - {sumNechetNub}";
}

System.Console.WriteLine(GetNechetNub());
