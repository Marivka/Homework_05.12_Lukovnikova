// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



var array = FillArray(15);
Print(array);
Console.WriteLine();
var count = GetCount(array);
Console.WriteLine(count);

int GetCount(int[] array)
{
    int count = 0;
    foreach(var item in array)
    {
        if(item > 0)
        {
            count++;
        }
    }
    return count;
}


int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}





