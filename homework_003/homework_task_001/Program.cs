//           Задача:
// Напишите программу, которая принимает 
//  на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//        Программа:


int number = 14241;

int n1 = 0;
int n2 = 1;

if (10000 <= number && number <=99999 )
{
    n1 = number / 1000;
    n2 = ((number % 10) * 10) + ((number % 100) / 10); 


    System.Console.WriteLine($"{n1}  {n2}");
}
else
{
    System.Console.WriteLine("error");
}

if (n1 == n2)
{
    System.Console.WriteLine($" ДА \n палиндром");
}
else
{
    System.Console.WriteLine("НЕТ");
}
