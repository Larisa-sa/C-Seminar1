// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -11 до 11
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = number * (-1);

while (count <= number)
{
   int number = int.Parse(Console.ReadLine());
    count ++;
}