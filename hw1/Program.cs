/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */


// Ввод размерности массива
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

//Ввод самого массива пользователем
int[] GetWriteArray(int num)
{
    if (num < 5) Console.WriteLine($"Введите {num} элемента массива, через запятую");
    else Console.WriteLine($"Введите {num} элементов массива, через запятую");

    string array = Console.ReadLine();
    string[] arr = array.Split(new char[] { ',' });
    int[] result = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = int.Parse(arr[i]);
    }
    return result;
}

//Подсчет положительных элементов массива
int GetPositiveCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int numb = GetNumber("Введите количество чисел: ");
int[] array = GetWriteArray(numb);
int count = GetPositiveCount(array);
Console.WriteLine($"Число положительных чисел в массиве равно {count}");
