//Считываем данные с консоли
string? inputLine1= Console.ReadLine();
string? inputLine2= Console.ReadLine();
string? inputLine3= Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine1!=null && inputLine2!=null && inputLine3!=null)
{
     //Изменяем введенные строки в целые числа
    int inputNumber1 = int.Parse(inputLine1);
    int inputNumber2 = int.Parse(inputLine2);
    int inputNumber3 = int.Parse(inputLine3);

    //Сравниваем первое и второе число
     if(inputNumber1 > inputNumber2)
    {
        //Если первое число больше, то сравниваем с третьим
        if(inputNumber1 > inputNumber3)
        {
            Console.WriteLine("Первое чмсло максимальное и равно"+ inputNumber1);
        }
       else
       {
        Console.WriteLine("Третье чмсло максимальное и равно"+ inputNumber3);
       }
    }
    else
    {
        //Если второе число больше, то сравниваем с третьим
        if(inputNumber2 > inputNumber3)
        {
            Console.WriteLine("Второе чмсло максимальное и равно"+ inputNumber2);
        }
        else
        {
            Console.WriteLine("Третье чмсло максимальное и равно"+ inputNumber3);
        }
    }
       
}

