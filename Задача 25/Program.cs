// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Реализовать функцию возведения в степень
// самостоятельно!

Double Degree(int numA, int numB)
{
    double result = 1;

    for (int i = 0; i < numB; i++)
    {
        result = result * numA;
    }

    return result;
}

Console.Clear();
Console.WriteLine("Введите число А:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine(Degree(numberA, numberB));
