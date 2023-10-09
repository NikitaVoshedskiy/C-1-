// Напишите программу, которая принимает на вход число N и выдает произведние чисело от 1 до N
//4->24
//5->120

int Proisvedenie(int num)
{
    int result = 0;
    if (num == 0)
    {
       
    }
    else
    {
    result = 1;
    for (int i=1;num>=i;i++)
    {
        result = result * i;
    }
    }
    return result;
}

System.Console.WriteLine("Введите число:");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int number = Proisvedenie(N);
System.Console.WriteLine(number);