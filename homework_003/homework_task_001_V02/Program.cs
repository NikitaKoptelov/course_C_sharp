//           Задача:
// Напишите программу, которая принимает 
//  на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//        Программа:



char GetNumbers (string number, int index)
{
    char[] array = new char[number.Length];
    for (int i = 0; i < number.Length; i++)
    {
        array[i] = number[i];
    }   

    return array[index];
    
}

string GetPalindrom (string number)
{
    
    if (GetNumbers(number, 0) == GetNumbers(number, 4) && GetNumbers(number, 1) == GetNumbers(number, 3))
    {
        return "ДА \n Полиндром";
    }
    else
    {
        return "НЕТ";
    }
}

System.Console.Write("Введите 5-ти значное число - ");
string number = Convert.ToString (System.Console.ReadLine());
System.Console.WriteLine(GetPalindrom(number));




