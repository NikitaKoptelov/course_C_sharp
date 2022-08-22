//       Задача:
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//         Программа :


string GetOneArray (string nub, int index)
{
    
    string[] twoArray = nub.Split(",");
    return twoArray[index];
}

string GetTwoArray (string nub, int index1, int index2)
{
    
    string[,] twoArray = new string[2, 5];
    int k = 0;
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            twoArray[i,j] = GetOneArray(nub, k);
            k++;
        }
        k = 5;
    }
    return twoArray[index1, index2];
}

int GetSumMax (string nub)
{
    
    int sumNub = 0;
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if ((Convert.ToInt32(GetTwoArray(nub, i, j))) > 0)
            {
                
                sumNub +=1;
            }
        }
    }
    return sumNub;
}

int GetSumMaxS1 (string nub)
{
    int sumNubS1 = 0;
    for (int j = 0; j < 5; j++)
    {
        if ((Convert.ToInt32(GetTwoArray(nub, 0, j))) > 0)
        {
            sumNubS1 += 1;
        }
    }
    return sumNubS1;
}

int GetSumMaxS2 (string nub)
{
    int sumNubS2 = 0;
    for (int j = 0; j < 5; j++)
    {
        if ((Convert.ToInt32(GetTwoArray(nub, 1, j))) > 0)
        {
            sumNubS2 += 1;
        }
    }
    return sumNubS2;
}






Console.Write("введите 10 числа через знак (,) - ");
string nub = Console.ReadLine();

PrintTweArray();
Console.Write("колличество чисел >0 общее - ");
Console.WriteLine(GetSumMax(nub));
Console.Write("колличество чисел >0 строки1 - ");
Console.WriteLine(GetSumMaxS1(nub));
Console.Write("колличество чисел >0 строки2 - ");
Console.WriteLine(GetSumMaxS2(nub));

void PrintTweArray ()
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.Write($"{GetTwoArray(nub, i, j)} ");
        }
        Console.Write("\n");
    }
}

