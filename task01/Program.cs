//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int Read(string arg)
{
    System.Console.Write($"Number : {arg} ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = Read("A");
int b = Read("B");
int Length = b;
int num = a;
int cube = 0;
int [] numbers = new int [Length-1];
for (int i = 0; i < numbers.Length; i++)
{
    cube = num * a;
    num = cube;
}

System.Console.WriteLine(cube);








