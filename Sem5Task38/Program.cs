//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
//[2 0,4 9 7,2 78] -> 77,6

// Метод генерации и заполнения массива вещественными числами
double[] FillArrayDouble(int arrLength, int numMin, int numMax)
{
    // Создаём массив
    double[] array = new double[arrLength];

    // Тест границ
    if (numMin < numMax)
    {
        // Заполняем массив
        for (int i = 0; i < arrLength; i++)
        {
            array[i] = new Random().NextDouble() * (numMax - numMin) + numMin;
        }
    }
    return array;
}

// Вывод массивa.
void Print1DArray(double[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// Метод, принимает строку, выводит в консоль.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Нахождение разницы между Макс и Мин элементом массива.
double MaxMin(double[] array)
{
    double Max = double.MinValue;
    double Min = double.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max) Max = array[i];
        if (array[i] < Min) Min = array[i];
    }
    return Max - Min;
}


double[] array = FillArrayDouble(5, 1, 99);
Print1DArray(array);

double difference = MaxMin(array);
PrintResult("Разница между Min и Max элементом массива: " + difference);


