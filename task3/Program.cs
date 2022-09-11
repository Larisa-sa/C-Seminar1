// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа
Console.Write("Введите трехзначное число : ");          
int number = int.Parse(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    Console.WriteLine(number % 10);

}
else
{
    Console.WriteLine("Введено неверное значение");
}