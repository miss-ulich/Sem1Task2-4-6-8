    // Задача 36
// Задайте одномерный массив, заполненный случайными числами. 
//   Найдите сумму элементов, стоящих на нечётных позициях.
//                  [3, 7, 23, 12] -> 19
//                  [-4, -6, 89, 6] -> 0
//-------------------------------------------------------------

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

// Сумму элементов, стоящих на нечётных позициях в массиве.
int noevenSumPosition(int[] array)
{
    int noEven = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        noEven += array[i];
    }
    return noEven;
}

// Метод, принимает строку, выводит в консоль.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[] array = FillArray(4, -10, 100);
Print1DArray(array);
PrintResult("Сумма элементов на нечётных позициях: " + noevenSumPosition(array));
