// Программа принимает два числа и проверяет, является ли первое число квадрату второго

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Квадрат вашего числа: ");
int square = Convert.ToInt32(Console.ReadLine());
if (number * number == square)
{
    Console.WriteLine("True");
    Console.Read();
}
else
{
    Console.WriteLine("false");
}