// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет (645 -5)

System.Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 99)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число.");
}

if (99 < num && num < 1000)
{
    System.Console.WriteLine($"3 цифра числа = {num % 10}");
}

// System.Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 99)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     System.Console.WriteLine(num % 10);
// }
// else
// {
//     System.Console.WriteLine("Вы ввели не трехзначное число.");
// }
