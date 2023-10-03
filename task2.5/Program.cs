// Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

//5, 25 -> да
//25 , 5 -> yes
//-4 , 16 -> yes
//8 , 9 -> no 

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1*number1 == number2 || number2*number2 == number1) System.Console.WriteLine("Является");
else System.Console.WriteLine("не является");