// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
int UserNumber = GetNumberFromUser("Задайте количество элементов в массиве: ","Ошибка ввода!");
int[] array = GetArray(UserNumber, 100, 999);
//Console.WriteLine(String.Join(" ", array));
int positiveSum = GetEvenCount(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> {positiveSum}");
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
int GetEvenCount(int[] arr)
{
    int evenCount = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) evenCount += 1;
    }
    return evenCount;
}
