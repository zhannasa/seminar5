// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] numbers = new int[5];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
int max = FindMax();
int min = FindMin();

int FindMax()
{
    int max = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}

int FindMin()
{
   int min = 0;
   for (int i = 0; i < numbers.Length; i++)
   {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
   }
   return min;
}

Console.WriteLine($"Max number = {max}, min number = {min}");
Console.WriteLine($"Difference between max and min = {max - min}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,100);
        }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


