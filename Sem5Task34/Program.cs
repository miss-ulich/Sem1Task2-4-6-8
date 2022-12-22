// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Универсальный метод генерации и заполнение массива.
int[] FillArray(int length, int topBorder, int downBorder)
{
    Random rand = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(topBorder, downBorder + 1);
    }
    return array;
}

// Вывод массивa.
void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// Возвращает количество чётных цифр в массиве.
int evenCount(int[] array)
{
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) evenCount++;
    }
    return evenCount;
}

// Метод, принимает строку, выводит в консоль.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[] array = FillArray(4, 100, 999);
Print1DArray(array);
PrintResult("Чётных чисел в массиве: " + evenCount(array));

