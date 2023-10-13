// 40 Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.


System.Console.WriteLine("Введите длинну стороны треугольника а: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите длинну стороны треугольника b: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите длинну стороны треугольника с: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a<b+c && b<a+c && c< a+b)
{
    System.Console.WriteLine("Треугольник может существовать");
}
else
{
    System.Console.WriteLine("Треугольник не может существовать");
}