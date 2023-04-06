//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int Read()
{
    System.Console.Write("Number : ");
    int number = int.Parse(Console.ReadLine());
    return number;
}
int a = Read();
int b = Read();
int stepen = b;
//for (int i=1; i<=n; i++)
     Console.WriteLine("a^b = " + Math.Pow(a, stepen));