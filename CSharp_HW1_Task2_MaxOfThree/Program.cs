// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

//РЕШЕНИЕ БЕЗ ИСПОЛЬЗОВАНИЯ МАССИВОВ

Console.WriteLine("Введите первое целое число:");
//перевод введённого значения в целочисленное Convert.ToInt32. В случае не дробного использовать Convert.Double
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число:");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (a > b)
{
    if (a > c)
    {
        Console.Write("max = ");
        Console.WriteLine(a);
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(c);
    }    
}
else
{
    if (b > c)
    {
        Console.Write("max = ");
        Console.WriteLine(b);
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(c);
    }
}