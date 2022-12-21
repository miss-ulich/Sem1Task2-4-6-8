//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num %10;
        num = num/10; 
        res++;
    }
    return res;
}
int number = ReadData("Введите число :" );

int num = SumDigit(number);

PrintData("");


