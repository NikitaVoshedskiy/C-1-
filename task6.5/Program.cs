// 44 не используя рекурсию, выведите первые N чисел Фибоначчию
// Первые два числа Фибоначчи: 0 и 1.
void Fibonacchchi (int[] arr)
{
    arr[0]=0;
    arr[1]=1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i]=arr[i-1]+arr[i-2];
    }
}

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];

Fibonacchchi(arr);
System.Console.WriteLine("["+string.Join(", ",arr)+"]");