//напишите программу , которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А
//7 ->28
//4->10
//8->36

int Sumnambers(int num)
{
    int sum = 0;
    for (int i=1; num >= i;i++)
    {
    sum += i;
    }
    return sum;
}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Sumnambers(number);
System.Console.WriteLine(result);
