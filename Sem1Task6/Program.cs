//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine!=null)
{
    //Изменяем введенную строку в целое число
    int inputNumber = int.Parse(inputLine);

    //Проверяем остаток на деления 2
    if ((inputNumber%2) == 0)
    {
        Console.WriteLine("Чмсло "+ inputNumber + "четное");
    }
    else
    {
        Console.WriteLine("Чмсло "+ inputNumber + "нечетное");
    }
}


