// Задача 34: Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int UserNumber = GetNumberFromUser("Задайте количество элементов в массиве: ","Ошибка ввода!");
int[] array = GetArray(UserNumber, -1000, 1000);
//Console.WriteLine(String.Join(" ", array));
int oddSum = GetSum(array, UserNumber);

Console.WriteLine($"[{String.Join(", ", array)}] -> {oddSum}");
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
// заполненный случайными числами из промежутка [minValue, maxValue]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// Возвращает сумму положительных чисел массива arr
int GetSum(int[] arr, int size)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    return sum;
}

