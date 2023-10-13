// 43 Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//k=k- paralel 
// k=b лежат на одной плоскости

System.Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToDouble (Console.ReadLine());
System.Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToDouble (Console.ReadLine());
System.Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToDouble (Console.ReadLine());
System.Console.WriteLine("Введите число b2: ");
double b2 = Convert.ToDouble (Console.ReadLine());
double x=0;
double y=0;
if(b1==k1 && k2==b2)
{
    y=k1*x+b1;
    y=k2*x+b2;
    System.Console.WriteLine("Прямые");
}
else if(k1==k2)
{
    System.Console.WriteLine($"Паралельные ");
}
else
{
    x=(b2-b1)/(k1-k2);
    y=k1*x+b1;
    y=k2*x+b2;
    System.Console.WriteLine("["+ x+","+y+"]");
}
