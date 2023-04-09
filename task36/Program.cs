// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] numbers = new int[4];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
int sum = CountSum(numbers);

int CountSum(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i+=2)
    {
        sum = sum + numbers[i];
    }
    return sum;
}
    
Console.WriteLine($"sum of odd position numbers = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
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
