// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] StringToArrayInt() // метод разбивающий строку на массив и переводящий элементы массива в числа
{
    Console.WriteLine("Введите числа через пробел: ");
    string numbers = Console.ReadLine();
    string[] elements = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] array = Array.ConvertAll(elements, s => int.Parse(s));
    return array;
}

int CountingPositiveNumbers(int[] array) // метод подсчета положительных чисел массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = StringToArrayInt();
Console.WriteLine();
int count = CountingPositiveNumbers(array);
Console.WriteLine($"Количество введенных Вами положительных чисел равно: {count}.");


