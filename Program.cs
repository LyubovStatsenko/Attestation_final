// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = { "Hello", "2", "world", "he" };
string[] newArray = new string[array.Length];
int j = 0;
foreach (string item in array)
{
    if (item.Length <= 3)
    {
        newArray[j] = item;
        j++;
    }
}

Console.WriteLine("Исходный массив:");
Console.WriteLine("[" + string.Join(", ", array) + "]");

Console.WriteLine("Новый массив:");
Console.WriteLine("[" + string.Join(", ", newArray) + "]");
