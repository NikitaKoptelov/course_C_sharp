//       Задача :
// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//      Программа :


string GetNumArray (string num, int j)
{
    char[] array = new char[num.Length];
    for (int i = 0; i < num.Length; i++)
    {
        array[i] = num[i];
    }   

    return Convert.ToString(array[j]);
    
}


int GetSummaN (string num)
{
    int res = 0;
    for (int j = 0; j < num.Length; j++)
    {
        int numS = Convert.ToInt32(GetNumArray(num, j));
        res+=numS;
    }
    return res;
}

System.Console.Write("введите число - ");
string num = Convert.ToString(System.Console.ReadLine());
System.Console.Write("Сумма цифр в числе - ");
System.Console.WriteLine(GetSummaN(num));
