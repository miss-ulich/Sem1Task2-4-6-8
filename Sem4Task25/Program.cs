//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (35) 2, 4 -> 16

//Ввод данных
int numberA = ReadData("Введите число: ");
int numberB = ReadData("Введите степень: ");
Pow(numberA, numberB);

//запрос данных у пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP; //возвращаем значение
}

// Метод вывода результата
void PrintResult(string line)
{
   Console.WriteLine(line);
}
// Функция возведения в степень
int Pow (int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberA; i++)
    {
    result = result * numberB;
    }
    return result;

}


PrintResult(",");


 	


