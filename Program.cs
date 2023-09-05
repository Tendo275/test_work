// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа 
// в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("write Num: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int num0 = num * -1;

while (num0 <= num)
{
   Console.WriteLine (num0);
   num0 ++;
}




// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Enter number: ");
string strNum = Console.ReadLine();
int WeekDay = int.Parse(strNum); 

if(WeekDay==1) 
{
    Console.WriteLine("Понедельник");
}

else if(WeekDay==2) 
{
    Console.WriteLine("Вторник");
}

else if(WeekDay==3) 
{
    Console.WriteLine("Среда");
}

else if(WeekDay==4) 
{
    Console.WriteLine("Четверг");
}

else if(WeekDay==5) 
{
    Console.WriteLine("Пятница");
}

else if(WeekDay==6) 
{
    Console.WriteLine("Суббота");
}

else if(WeekDay==7) 
{
    Console.WriteLine("Воскресенье");
}

else 
{
   Console.WriteLine("Вы ввели некорректное число"); 
}





// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Write("Enter number: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Enter number: ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

int sqr = num2 * num2;

if (sqr == num1)
{
System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}




// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.Write("Enter three digit number: ");
int num = int.Parse(Console.ReadLine());
if(num >= 100 && num <= 999)
{
  Console.WriteLine(num % 10);
}
else Console.WriteLine("Enter next number");




// *Домашнее задание по Семинару № 1*


// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
// a = 5; b = 7 -> max = 7 
// a = 2 b = 10 -> max = 10 
// a = -9 b = -3 -> max = -3


Console.Write("Enter number: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Enter number: ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

if(num1 > num2)
{
    Console.WriteLine("Большее число: ", num1);
    Console.WriteLine("Меньшее число: ", num2);
}
else
{
    Console.WriteLine("Большее число: ", num2);
    Console.WriteLine("Меньшее число: ", num1);
}

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter number: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Enter number: ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

Console.Write("Enter number: ");
strNum = Console.ReadLine();
int num3 = int.Parse(strNum);

int max = num1;

if(num2 > max)
{
    max = num2$
}
if(num3 > max)
{
    max = num3;
}

Console.WriteLine("Большее число: " + max);

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число:");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

if (num1 % 2 == 0)
{
    Console.WriteLine("Число является четным.", num1);
}
else
{
    Console.WriteLine("Число не является четным.", num1);
}


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N:");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);
        
int num2 = 1;

for(int num2 <= num1; num2 ++)
{
    if(num2 % 2 == 0)
    {
        Console.WriteLine (num2);
    }
}

Console.WriteLine (num2);