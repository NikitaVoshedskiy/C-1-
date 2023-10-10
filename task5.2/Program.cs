//  32 Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
//и наоборот.
// [-4. -8 ,8 ,2 ] -> [4,8,-8,-2]

void MAS (int[] arr)
{
    Random rnd = new Random();
    for (int i =0; i<arr.Length; i++)
    {
        System.Console.WriteLine($"Напишите число, которое будет в массиве под индексом:{i}");
        arr[i]= Convert.ToInt32(Console.ReadLine());
    }
}

void NGPS(int[] args)
{
    for (int i =0; i<args.Length; i++)
    {
        args[i]*=-1;
    }
}
System.Console.WriteLine("Введите длинну массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[N];
MAS(mas);
System.Console.WriteLine('['+string.Join(", ", mas)+']');
NGPS(mas);
System.Console.WriteLine('['+string.Join(", ", mas)+']');

