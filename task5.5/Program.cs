// 37 Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и и.д.
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6 ]-> 36 21

void MAS (int[] arr)
{
    Random rnd = new Random();
    for(int i = 0; i<arr.Length;i++)
    {
        arr[i]= rnd.Next(0,10);
    }
}

System.Console.WriteLine("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[n];

MAS(mas);
System.Console.WriteLine("["+string.Join(", ", mas) + "]");


int[] prois;
if (n % 2 == 0)
{
    prois = new int[n/2];
}
else
{
    prois = new int[n/2 +1];
    prois[n/2]= mas[n/2];
}

for (int i =0; i<mas.Length/2;i++)
{
    prois[i]= mas[i]*mas[mas.Length-i-1];
}
System.Console.WriteLine("["+string.Join(", ", prois) + "]");
