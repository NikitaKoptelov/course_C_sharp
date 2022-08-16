//         Задача:
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
//              Программм:


string GetWeek(int numb)
{
    string NumbWeek1 = "да";
    string NumbWeek2 = "нет";
    if(6 <= numb && numb <= 7)
    {
        return NumbWeek1;
    }
    else if (1 <= numb && numb <= 5)
    {
        return NumbWeek2;
    }
    else
    {
        return "Ошибка";
    }
}

System.Console.Write("Введите номер дня недели - ");
int numb = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetWeek(numb));

