﻿// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа (456 - 5)
System.Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (99 < num && num < 1000)
{
    System.Console.WriteLine($"Вторая цифра числа = {(num / 10) % 10}");
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число.");
}
