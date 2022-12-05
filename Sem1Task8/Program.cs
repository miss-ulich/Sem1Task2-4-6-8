//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine1!=null)
{
     //Изменяем введенную строку в целое число
    int inputNumber = int.Parse(inputLine);
    int index = 2;

    string outLine = string.Empty;

    while (index<= inputNumber-2)
    {
        //Приписываем четные числа
        outLine = outLine + index + ',';
        index = index+2;
    }
    outLine=outLine+index;
    //outLine = outLine.TrimEnd(',');

    Console.WriteLine(outLine);
}
