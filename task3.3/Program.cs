//Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

//System.Console.WriteLine(Math.Pow(num,2)); // Math.Pow() - возведение в степень
//System.Console.WriteLine(Math.Sqrt(num,2)); // Math.Sqrt() - Извлечение квадратного корня
//Math.Round(num,3) - округление дробного числа до 3 цифры после запятой

double DISTANCE (double x1, double y1 , double x2, double y2)
{
double distance = Math.Round (Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)),3);
return distance;
}
Console.Write("Введите Х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1: ");
double y1 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите X2: ");
double x2 = Convert.ToDouble (Console.ReadLine());
Console.Write("Введите Y2: ");
double y2 = Convert.ToDouble (Console.ReadLine());

System.Console.WriteLine("Расстояние равно " + DISTANCE (x1,y1,x2,y2));