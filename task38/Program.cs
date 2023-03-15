// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
int UserNumber = GetNumberFromUser("Задайте количество элементов в массиве: ","Ошибка ввода!");
double[] array = GetArray(UserNumber);
Console.Write($"[{String.Join(", ", array)}] ");
double MaxMinusMin = GetMaxMinusMin(array, UserNumber);

Console.WriteLine($"-> {MaxMinusMin}");
//////////////////////////////////////////////////////////////////////////////////

// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
int GetNumberFromUser(string message, string errorMessage)
{ 
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect) return userNumber;
        Console.WriteLine(errorMessage);
    } 
}

// Возвращает массив из size элементов,
// заполненный случайными числами 
double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next();
    }
    return res;
}


// Возвращает сразницу между максимальным и минимальным элементов массива.
double GetMaxMinusMin(double[] arr, int size)
{
    Array.Sort(arr);
    double minus = arr[size - 1] - arr[0];
    return minus;
}
