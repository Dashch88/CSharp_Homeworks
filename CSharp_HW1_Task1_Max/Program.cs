// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое целое число:");
//перевод введённого значения в целочисленное Convert.ToInt32. В случае не дробного использовать Convert.Double
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
}