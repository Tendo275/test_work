namespace PowerCalc { class Program { static void Main(string[] args) 
{ Console.WriteLine(“Введите число A: ”); 
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(“\nВведите степень B: ”);
int B = Convert.ToInt32(Console.ReadLine());

if (B == 0)
{
    Console.WriteLine($“A^B = 1 (A и B равны 0)”);
}
else
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
    Console.WriteLine($“{A}^({B}) = {result}”);
}

Console.ReadKey();
}
}
}




class MainClass { public static void Main (string[] args) { int number;

Console.Write("Введите число: ");
number = int.Parse(Console.ReadLine());

int sum = 0;
while (number != 0) {
    sum += number % 10;
    number /= 10;
}

Console.WriteLine("Сумма цифр: " + sum);
}}



class Program 
{

static void Main() {
Random rnd = new Random();
int[] array = new int[8];
for(int i=0;i<8;i++) {
array[i] = rnd.Next(1, 20);
}

Console.WriteLine("Массив: “);
foreach(int x in array) {
Console.Write(”{0} ", x);
}

Console.ReadKey();
}
}