//Считываем данные с консоли
string? inputLine1= Console.ReadLine();
string? inputLine2= Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine1!=null && inputLine2!=null)
{
     //Изменяем введенные строки в целые числа
    int inputNumber1 = int.Parse(inputLine1);
    int inputNumber2 = int.Parse(inputLine2);

    //Проверяем, если числа равны

    if(inputNumber1==inputNumber2)
    {
        Console.WriteLine("Числа равны");
    }
    //Проверяем условие, первое число больше второго
    else
    {
        if(inputNumber1 > inputNumber2)
        {
            Console.WriteLine(inputNumber1 + "больше" + inputNumber2);
        }
        else
        {
            Console.WriteLine(inputNumber1 + "меньше" + inputNumber2);
        }
    }
}
