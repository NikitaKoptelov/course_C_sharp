//         Задача:
// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
//      Программа:



string GetChetNub()
{
    int[] nubArray = new int[50];
    int sumChetNub = 0;
    for (int i = 0; i < nubArray.Length; i++)
    {
        nubArray[i] = new Random().Next(99, 999);
        if (nubArray[i] % 2 == 0)
        {
            sumChetNub += 1;
        }
    }
    return $"сумма четных чисел в массиве - {sumChetNub}";
}


System.Console.WriteLine(GetChetNub());

