// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateArray(int min, int max)
{
int [] numbers = new int [8];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(min,max +1);
}
return numbers;
}

void PrintArray(int [] numbers)
{
System.Console.Write("[");
for (int i = 0; i < numbers.Length -1; i++)
{
    System.Console.Write(numbers[i] + "; ");
}
System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}

int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int min = Num("меньшее число");
int max = Num("максимальное число");
int [] numbers = CreateArray(min, max);
PrintArray(numbers);