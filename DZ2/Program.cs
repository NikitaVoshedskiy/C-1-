Console.WriteLine("Введите число №1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №3:");
int num3 = Convert.ToInt32(Console.ReadLine());

//Вариант №1
int max = num1;

if (num1>max) max = num1;
if (num2>max) max = num2;
if (num3>max) max = num3;
Console.WriteLine($"{max} самое большое число!");

//Вариант №2

/*if (num1 < num2 && num3 > num2)
{
    Console.WriteLine("num3 самое большое число");
}
if (num1 < num2 && num2 > num3)
{
    Console.WriteLine("num2 самое большое число");
}
if (num2 < num1 && num2 > num3)
{
    Console.WriteLine("num1 самое большое число");
}
*/