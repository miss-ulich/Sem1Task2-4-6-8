//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

 int X1 = ReadData("Введите координату Х1: ");
 int Y1 = ReadData("Введите координату Y1: ");
 int Z1 = ReadData("Введите координату Z1: ");
 int X2 = ReadData("Введите координату Х2: ");
 int Y2 = ReadData("Введите координату Y2: ");
 int Z2 = ReadData("Введите координату Z2: ");

 double result = DistanceBetweenPoints(X1, Y1, Z1, X2, Y2, Z2);

 PrintData("Расстояние между точками: ", result);


 //PrintData("Расстояние между точками: ", DistanceBetweenPoints(ReadData("Введите координату Х1: "), ReadData("Введите координату Х1: "), ReadData("Введите координату Х1: "), ReadData("Введите координату Х1: ")));


 // Метод читает данные от пользователя
 int ReadData(string msg)
 {
     Console.WriteLine(msg);
     return int.Parse(Console.ReadLine() ?? "0");
 }

 //Метод находит расстояние между точками на плоскости
 double DistanceBetweenPoints(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
 {
     double distance = Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2)+(Z1-Z2)*(Z1-Z2));
     return distance;
 } 

 //Метод выводит данные пользователю
 void PrintData(string msg, double res)
 {
     Console.WriteLine(msg + res);
}


