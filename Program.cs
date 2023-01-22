// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int InputInt(string massage)
{
    Console.WriteLine(massage);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int number = InputInt("Введите трёхзначное число");
int a = number%10;
int b = number%100;
int c = (b-a)/10;
System.Console.WriteLine($"вторая числа числа {number} равна {c}");

