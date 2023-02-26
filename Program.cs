// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

Console.Write("Введи размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
for (int i = 0; i < array.Length; i++)
{
        Console.Write($"Введи {i + 1} слово масcива:");
        array[i] = Console.ReadLine();
}
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
        Console.Write($"{array[i]} ");
        
}
Console.Write("\b]"); 

// string FillArray(string[] arr, string n)
// {
//     string[] arr = new string[n];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"Введи {i + 1} слово масcива:");
//         array[i] = Console.ReadLine();
//     }
//     return arr[];
// }

// FillArray(array, size);