/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив
строк, длина которых меньше или равна 3 символа. Первоначальный массив
ввести с клавиатуры.

Пример:
["Hello", "2", "world", :-)] -> ["2", ":-)"]
*/
int j = 0;
Console.Clear();
Console.Write("Введите количество слов в строке: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = GetArray(size);
PrintArray(array);
Console.WriteLine();

string[] changeArray = ChangeArray(array);
string[] result = ReplaceArray(changeArray);
PrintArray(result);

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

string[] ChangeArray(string[] array)
{
    string[] changeArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            changeArray[j] = array[i];
            j++;
        }
    }
    return changeArray;
}

string[] ReplaceArray(string[] array)
{
    string[] result = new string[j];
    for (int i = 0; i < j; i++)
    {
        if (array[i].Length == 0)
        {
            i++;
        }
        else result[i]= array[i];
    }
    return result;
}
