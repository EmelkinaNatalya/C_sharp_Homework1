// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int numFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numSecond = Convert.ToInt32(Console.ReadLine());

if (numFirst>numSecond)
    Console.Write($"Число {numFirst} является max");
if (numFirst == numSecond)
    Console.Write($"Введенные числа равны");

if (numFirst<numSecond)
    Console.Write($"Число {numSecond} является max");
