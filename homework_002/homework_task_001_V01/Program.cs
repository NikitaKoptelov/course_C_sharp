//                     Задача :
// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
//                 Программа :


int CheckNumb (int numb)                     // создаем метод по определению 3-х значного числа.
{
    if (99 < numb && 1000 > numb)
    {
        return numb;                            // возвращаем 3-х значное число.
    }
    else
    {
        return numb = -1;                       // возвращаем -1 (ошибку) при нарушении условий.
    }
}

int GetNumb (int numb)                              // создаем метод для математического разложения 3-х значного числа на числа 
{
        
    if (-1 < CheckNumb(numb))
    {
        int numb1 = (numb / 10) % 10;
        return numb1;                                 // возвращаем второе число из 3-х значного числа.
    }
    else
    {
        return-1;                                        // возвращаем -1 (ошибку) при нарушении условитй.
    }
}


Console.Write("Введите 3-х значное число - ");
int numb = int.Parse(Console.ReadLine());
Console.WriteLine(GetNumb(numb));
