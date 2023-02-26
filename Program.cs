// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

Console.Write("Введи размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
string[] array2 = new string[size];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введи {i + 1} слово масcива :");
    array[i] = Console.ReadLine();
}
Console.WriteLine("Введенный массив: ");
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");

}
Console.Write("\b]");
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        array2[i]=array[i];
    }
}
Console.WriteLine("Сортированный массив: ");
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array2[i]} ");

}
Console.Write("\b]");