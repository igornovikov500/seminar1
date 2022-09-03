// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(number) >= 100 && Math.Abs(number) < 1000)  
{
  int digit12 = number / 10; 
  int digit2 = digit12 % 10; 
  Console.WriteLine($"Вторая цифра числа {number}: {Math.Abs(digit2)}"); 
}
else
{
  Console.WriteLine("Число должно быть трехзначным!");
}