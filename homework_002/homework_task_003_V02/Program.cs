//         Задача:
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
//              Программм:


System.Console.Write("Введите номер дня недели - ");
int numb = Convert.ToInt32(System.Console.ReadLine());

string NumbWeek1 = "да";
string NumbWeek2 = "нет";
string NumbWeek3 = "ошибка";

if(6 <= numb && numb <= 7)
{
    System.Console.WriteLine(NumbWeek1);
}
else if (1 <= numb && numb <= 5)
{
    System.Console.WriteLine(NumbWeek2);
}
else
{
    System.Console.WriteLine(NumbWeek3);
}


