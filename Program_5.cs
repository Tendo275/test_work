// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


Write("Введите размер массива: ");
intlength=int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
intmin=int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
intmax=int.Parse(ReadLine()!);
int[] Array= GetArray(length, min, max);
WriteLine($"[{string.Join(", ", Array)}]"); 
FindEven(Array);
int[] GetArray(intsize, intminValue, intmaxValue)
{
    Randomrnd= newRandom(); 
    int[] result= newint[size];
    for(inti= 0; i< result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+ 1);
    }
    returnresult;
}
voidFindEven(int[] MyArray)
{
    inteven=0;
    for(inti= 0; i< MyArray.Length; i++)
    {
        if(MyArray[i]%2==0)
        {
            even=even+1;
        }
    }
    WriteLine($"Чётных чисел {even}");
}



// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


Write("Введитеразмермассива: ");
intlength=int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
intmin=int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
intmax=int.Parse(ReadLine()!);
int[] Array= GetArray(length, min, max);
WriteLine($"[{string.Join(", ", Array)}]");
 FindOdd(Array);
 int[] GetArray(intsize, intminValue, intmaxValue)
 {
    Random rnd= newRandom();
    int[] result= newint[size];
    for(inti= 0; i< result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+ 1);
    }
    returnresult;
}

voidFindOdd(int[] MyArray)
{
    intodd=0;
    for(inti= 1; i< MyArray.Length; i=i+2)
    {
        odd=odd+MyArray[i];
    }
    WriteLine($"Суммачиселнанечётныхпозициях{odd}");
}


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


Write("Введитеразмермассива: ");
intlength=int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
intmin=int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
intmax=int.Parse(ReadLine()!);
int[] Array= GetArray(length, min, max);
WriteLine($"[{string.Join(", ", Array)}]"); 
FindDifference(Array, max, min);
int[] GetArray(intsize, intminValue, intmaxValue)
{
    Random rnd= newRandom(); 
    int[] result= newint[size];
    for(inti= 0; i< result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+ 1);
    }
    returnresult;
}

voidFindDifference(int[] MyArray, intminVal, intmaxVal)
{
    for(inti= 0; i< MyArray.Length; i++)
    {
        if(MyArray[i] < minVal)
        {
            minVal=MyArray[i];
        }
        if(MyArray[i] > maxVal)
        {
            maxVal=MyArray[i];
        }
    }
    WriteLine($"Разница {maxVal-minVal}");
}