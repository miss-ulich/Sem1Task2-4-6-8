 // Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) 
//      и возводит число A в натуральную степень B.
//------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаме значение
    return number;
}

// Возведение в степень
long Pow(int A, int B)
{
    long res = 1;
    for (int i = 0; i < B; i++)
    {
        res = res * A;
    }
    return res;
}

// Метод вывода результата 
void PrintData(long line)
{
    Console.WriteLine(line);
}

int numberA = ReadData("Введите число А ");
int numberB = ReadData("Введите число B ");
long res = Pow(numberA, numberB);
PrintData(res);



 	


