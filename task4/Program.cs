// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"



Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
int negativeNumber = -number; // number = 4, а negnumber = -4 => диапазон хода [-4,4]
while (negativeNumber <= number)
{
Console.Write(negativeNumber + ", "); // == Console.Write($"{negativeNumber}, ") // -4 -3 -2 -1 0 1 2 3 4
negativeNumber++; // == negativeNumber = negativeNumber + 1; - negnum = -3
}
}
else
{
Console.WriteLine("Введите положительное число!");
}