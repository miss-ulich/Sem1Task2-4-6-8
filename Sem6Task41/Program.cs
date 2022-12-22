
// Задача 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//     сколько чисел больше 0 ввёл пользователь.
//                0, 7, 8, -2, -2 -> 2
//                1, -7, 567, 89, 223-> 3
//

// Метод считывания данных пользователя
string ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем строку
    string inputLine = Console.ReadLine() ?? "";
    // Возвращаем значение
    return inputLine;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод, запрашивающий заданное количество чисел, возвращает количество положительных их них
int CountPositives(int quantity)
{
    // Вводим счётчик положительных чисел
    int positiveNum = 0;

    // В цикле запрашиваем число, парсим, проверяем положительное, увеличиваем счётчик
    for (int i = 0; i < quantity; i++)
    {
        int inputNumber = 0;
        string inputLine = ReadData($"Введите {i + 1}-е число: ");

        if (int.TryParse(inputLine, out inputNumber))
        {
            if (inputNumber > 0) positiveNum++;
        }
    }
    return positiveNum;
}

int inputQuantity = 0;
string inputLineQuantity = ReadData("Введите количество чисел: ");

// Если введенная строка преобразуется в число - сохраняем в переменную.
// Словом "out" обозначается переменная, в которую будет сохранено преобразованное из строки число, это output 
if (int.TryParse(inputLineQuantity, out inputQuantity))
{
    PrintResult($"Введено положительных чисел: {CountPositives(inputQuantity)}");
}
else
{
    Console.WriteLine("Это не число");
}

//Вариант со *
//using System.Text.RegularExpressions; //без явного указания сборки не работают регулярные выражения.

//int taps = ReadData("Введите количество нажатий");

//string inputLine = ReadLineData("Введите любые символы с клавиатуры.");
//Console.WriteLine(inputLine);

//FindNumbersInString(inputLine,taps);

////Методы
//int ReadData(string msg)//метод запрашивает и ситывает данные с консоли
//{
//    Console.WriteLine(msg);
//    return int.Parse(Console.ReadLine() ?? "0");
//}

//string ReadLineData(string msg) //метод считывает нажатие клавиш на клавиатуре заданное количество раз и собирает данные в строку через запятую
//{
//Console.WriteLine(msg);
//string line = "";
//for (int i = 0; i < taps; i++)
//{
//    var key = Console.ReadKey(true); //параметр true указан для того, чтобы после нажатия клавиш ничего не появлялось в консоли
//    line = line + String.Format(key.KeyChar.ToString()) + ","; 
//}
//line = line.TrimEnd(','); //кусь последнюю запятую
//return line;
//}

//void FindNumbersInString(string str, int count)//метод для поиска десятичных цифр в строке с помощью регулярных выражений
//{
//Regex regex = new Regex(@"\d");//задаем для поиска параметр "любая десятичная цифра"
//MatchCollection matches = regex.Matches(str); //задаем коллекциюЮ состоящую из найденных по условию выражений 
//int posNums = 0;
//if (matches.Count > 0) //если цифры найдены, то накапливаем результат. Каждая найденная цифра +1 к итогу.
//{
//    foreach (Match match in matches)
//    {
//        posNums = posNums + 1;
//    }
//    Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов найдено чисел: {posNums}");
//}
//else
//{
//    Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов чисел не найдено");
//}
