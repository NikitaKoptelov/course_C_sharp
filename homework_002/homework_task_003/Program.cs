//         Задача:
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
//              Программм:

//массив для вывода решения   {    0,     1,      2,      3,     4,     5,    6,    7}
string[] NumbWeekArray = {"error", "нет", "нет", "нет", "нет", "нет", "да", "да"};   // создал множество для под условий полученного результата.

string GetWeek(int numb)                                                      // создал метод для проверки условий и вывода нужного результата.
{
    if(6 <= numb && numb <= 7)
    {
        return NumbWeekArray[numb];
    }
    else if (1 <= numb && numb <= 5)
    {
        return NumbWeekArray[numb];
    }
    else
    {
        return "error";                                                                   // вывод сообщение об ошибки при не соблюдении условий.
    }
}

System.Console.Write("Введите номер дня недели - ");
int numb = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(GetWeek(numb));
