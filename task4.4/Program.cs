// Напишите программу которая выводит массив из 8 элементов, заполненный нудями и единицами в слуйчайном порядке
// [1,0,1,0,1,1,1,1]

int[] mass = new int[8];
Random rnd = new Random();
for (int i = 0; i<mass.Length; i++)
{
    mass[i] = rnd.Next(0, 2);
}
System.Console.WriteLine('[' + string.Join(", ", mass) + ']');

