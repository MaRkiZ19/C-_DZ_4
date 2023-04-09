// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Number(string message)
{
    System.Console.Write(message);
    string Input = Console.ReadLine();
    int result = int.Parse(Input);
    return result;
}

int Summ(int number)
{
    int result = 0;
    while(number>0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Number("Введите число: ");
System.Console.WriteLine($"Сумма цифр в числе {number} = {Summ(number)}");
