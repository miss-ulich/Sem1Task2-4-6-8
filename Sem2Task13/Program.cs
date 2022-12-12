//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Вводим число
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()??"0");

//Делаем цикл
if (number > 99)
{
    //Находим количество цифр в числе
    int length = (int)Math.Log(number) + 1;

    int index = 0;
    while (index < length - 3)
    {
        number = (number / 10) % 10;
        index ++;
    }
}
else
{
    Console.WriteLine("Ввели не трехзначное число");
}
