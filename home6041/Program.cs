// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int FindNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] CreateMassive(int M, int begin, int end)
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        array[i] = new Random().Next(begin, end+1);
    }
    return array;
}

// Задаем массив
int[] arr =  CreateMassive(8, -100, 100);
Console.Write(String.Join(" , ", arr));
// ищем положительные числа и считаем их
int count = FindNumber(arr);
// выводим результат на экран
Console.Write($" -> {count} ");