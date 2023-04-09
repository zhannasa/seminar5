// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Enter array size: ");
int size = ReadNumberFromConsole();
int[] array = new int[size];
FillArrayRandomNumbers(array);
Console.WriteLine("Array: ");
PrintArray(array);
int count = CountEvenNumbers(array);

int ReadNumberFromConsole()
{
    string input = Console.ReadLine();
    return int.Parse(input);
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"{array.Length} numbers, {count} of them - even");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
