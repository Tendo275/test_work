

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


static void Main(string[] args)
    {
        Console.WriteLine("Введите трёхзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        int secondDigit = (number / 10) % 10;
        
        Console.WriteLine("Вторая цифра числа: " + secondDigit);
    }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


static void Main (string[] args)  

    Console.Write("Enter a number: ");
    string input = Console.ReadLine();

    int number;
    if (int.TryParse(input, out number)) 
    {
      int thirdDigit = (number % 10) % 10;
      if (thirdDigit == 0) 
      {
        Console.WriteLine("There is no third digit.");
      } 
      else 
      {
        Console.WriteLine("The third digit is: " + thirdDigit);
      }
    } 
    else 
    {
      Console.WriteLine("Invalid input.");
    }  


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

static void Main()
    {
        Console.Write("Введите номер дня недели (1 - понедельник, 7 - воскресенье): ");
        int day = Convert.ToInt32(Console.ReadLine());
        if (day == 6 || day == 7)
        {
            Console.WriteLine("{0} - это выходной день", day);
        }
        else
        {
            Console.WriteLine("{0} - это рабочий день", day);
        }
    }