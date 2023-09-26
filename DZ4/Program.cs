Console.WriteLine("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 1;

if (num1 > num2)
{
while (num2<=num1)
{
    if (num2 % 2 == 0)
    {
      Console.Write($"{num2}, ");
    }
    num2++;
}
}
else
{
    Console.WriteLine("Введите число болше одного");
}
