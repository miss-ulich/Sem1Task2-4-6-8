﻿//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

//Ввод данных
int number = ReadData("Введите пятизначное число: ");
if ( number >= 10000 && number <= 99999)
{

    //Проверяем, является ли введенное число палиндромом
    bool check = PalinTest(number);
    if (check)
    {
        PrintData(number, "палиндром");
    }
    else
    {
        PrintData(number, " не палиндром");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
//Выводим данные на консоль
int ReadData(string mesage)
{
        Console.Write(mesage);
        return int.Parse(Console.ReadLine()??"0");
}
//Метод вывода данных
void PrintData(int number, string msg)
{
    Console.WriteLine(number+ msg);
}
bool PalinTest(int number)   
{

    bool result = false;
    result = (number/10000==number%10&&(number/1000)%10==(number/10)%10);
    return result;
}
