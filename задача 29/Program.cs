// Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.

void enterArray ()
{
    int[] myArray = new int[8];

    for (int i = 1; i < 8; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива: ");
        myArray[i] = int.Parse(Console.ReadLine());        
    }

    Console.Clear();
    Console.WriteLine($"Вот ваш массив: ");

    for (int i = 0; i< 8; i++)
    {
        Console.Write($"{myArray[i]} ");
    }        
}
enterArray();