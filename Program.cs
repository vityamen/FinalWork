/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив
строк, длина которых меньше или равна 3 символа. Первоначальный массив
ввести с клавиатуры.

Пример:
["Hello", "2", "world", :-)] -> ["2", ":-)"]
*/

Console.Clear();
Console.Write("Введите количество слов в строке: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = GetArray(size);
PrintArray(array);

string[] GetArray(int size)
{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите значение {i} слова:");
        result[i] = Console.ReadLine();
    }
    return result;
}

void PrintArray(string[] array)
{
    for(int i= 0; i < array.Length; i++)
    {
        int length = array.Length;
        { 
        if(i < length-1)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        else Console.Write($"\"{array[i]}\"");
        }
    }
}

