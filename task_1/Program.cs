// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



Console.WriteLine("Введите количество цифр ");
int count = Convert.ToInt32(Console.ReadLine());
int countMoreZero = 0;
for (int i = 0; i < count; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        countMoreZero++;
    }
}
Console.WriteLine(countMoreZero);
