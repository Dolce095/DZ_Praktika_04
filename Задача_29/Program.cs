// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

Console.Clear();

int[] array = new int[8];
Console.WriteLine("Введите кол-во элементов, ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < array.Length; i++)
array[i] =Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("[" + string.Join(" , ", array) + "]");
