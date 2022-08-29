//       Задача :
// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//      Программа :


int GetSum (int num)
{
    if (num < 999999999)
    {
        int sum = 0;
        while (num != 0)
        {
            sum+=num%10;
            num/=10;
        }
        return sum;
    }
    else
    {
        return -1;
    }
}


System.Console.Write("Введите число - ");
int num = Convert.ToInt32(System.Console.ReadLine()) ;
System.Console.Write("Сумма цифр в числе - ");
System.Console.WriteLine(GetSum(num));
