// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Sums (int num)
{
    int sum = 0;
    while (num >0)
    {
        sum += num%10;
        num= num /10;
    }
    return sum;
}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int N = Sums(number);
System.Console.WriteLine($"Сумма чисел получается: {N}");