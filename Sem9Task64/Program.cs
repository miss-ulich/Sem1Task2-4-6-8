//----------------Задача 64-----------------
// Напишите программу, которая выдаёт все 
// натуральные числа в промежутке от N до 1
//------------------------------------------

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// Метод, число N, возвращает строку чисел от N до 1
string LineGenRec(int num)
{
    if (num <= 0)
    {
        return string.Empty;
    }
    else
    {
        string outLine = num + " " + LineGenRec(num - 1);
        return outLine;
    }
}

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintResult(resultLine);
