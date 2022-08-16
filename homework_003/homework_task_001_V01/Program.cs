//           Задача:
// Напишите программу, которая принимает 
//  на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//        Программа:



string GetPalindrome (int number)
{
    if (10000 <= number && number <=99999 )
    {
        int n1 = number / 1000;
        int n2 = ((number % 10) * 10) + ((number % 100) / 10);
        if (n1 == n2)
        {
            return " ДА \n палиндром";
        }
        else
        {
            return "НЕТ";
        }
    }
    else
    {
        return "error";
    }
}


System.Console.Write("Введите 5-ти значное число - ");
int number = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetPalindrome (number));



