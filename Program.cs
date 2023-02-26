// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

Console.Write("Введи размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
string[] array2 = new string[size];
FillArray();
Console.WriteLine("Введенный массив: ");
PrintArray(array);
SortArray(array, array2);
Console.WriteLine("Сортированный массив: ");
PrintArray(array2);
void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введи {i + 1} слово масcива :");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");

    }
    Console.Write("\b]");
    Console.WriteLine();
}

void SortArray(string[] arr1, string[] arr2)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[i] = array[i];
        }
    }
}
 