// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine($"Введите какой длинны будет массив: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Arr = new int [N];
for (int i = 0;i<Arr.Length;i++)
{
    System.Console.WriteLine($"Введите число, кторое будет под индексом {i}");
    Arr[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.Write("[ ");
for (int i = 0;i<Arr.Length-1;i++)
{
    System.Console.Write(Arr[i]+ ", ");
}
System.Console.WriteLine(Arr[Arr.Length-1]+" ]");

//System.Console.WriteLine("[" + string.Join(", ",Arr) + "]");