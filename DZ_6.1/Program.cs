// 41 Пользователь вваодит с клавиатуры М чисел Посчитайте, сколько чисел больше 0 ввел пользователь.
//0,7,8,-2,-2 -> 2
int Message(string mes)
{
    System.Console.WriteLine(mes);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void FullRage (int[] args)
{
    Random rnd = new Random();
    for (int i = 0; i < args.Length; i++)
    {
        System.Console.WriteLine($"Введите число под номером {i+1}");
       args[i]= Convert.ToInt32(Console.ReadLine());
    }
}

int Chislo(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0) count++;
    }
    return count;
}

//System.Console.WriteLine("Введите число: ");
//int N = Convert.ToInt32(Console.ReadLine());
int Length = Message("Введите количество элементов:");
int[] arr = new int[Length];
FullRage(arr);
int number = Chislo(arr);
System.Console.WriteLine("["+string.Join(", ",arr)+"]");
System.Console.WriteLine($"Чисел больше нуля: {number}");