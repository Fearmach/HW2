// Написать программу, которая принимает на вход цифру обозначающую день недели и проверяет, является ли этот день недели выходным

 System.Console.WriteLine("Введите цифру дня недели: ");
 int num = Convert.ToInt32(Console.ReadLine());

 if (num == 1)
  {
     System.Console.WriteLine("Понедельник - не выходной");
  }
  else if (num == 2)
  {
     System.Console.WriteLine("Вторник - не выходной");
  }
  else if (num == 3)
  {
     System.Console.WriteLine("Среда - не выходной");
  }
  else if (num == 4)
  {
     System.Console.WriteLine("Четверг - не выходной");
  }
  else if (num == 5)
  {
     System.Console.WriteLine("Пятница - не выходной");
  }
  else if (num == 6)
  {
     System.Console.WriteLine("Суббота - выходной");
  }
  else if (num == 7)
  {
     System.Console.WriteLine("Воскресенье - выходной");
  }
  else 
  {
     Console.WriteLine("Такого дня не бывает");
  }


// System.Console.WriteLine("Введите цифру дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day > 0 && day < 6)
//  {
//     System.Console.WriteLine("Не выходной");
//  }
//  else if (day == 6 || day == 7)
//  {
//     Console.WriteLine("Выходной");
//  }
//  else 
//  {
//     System.Console.WriteLine("Такого дня недели не бывает");
//  }