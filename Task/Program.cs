// Задача.
// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


using System;
using static System.Console;
Clear();

WriteLine("Введите элементы массива через пробел:");
string[] inputArray = GetInputArrayFromString(ReadLine());
int index = 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        index = index + 1;
    }
}

string[] outputArray = new string[index];
WriteLine($"[{String.Join(", ", inputArray)}]");
MainTask(inputArray);
PrintArray(outputArray);


string[] GetInputArrayFromString(string arrayString)
{
    string[] arrStr = arrayString.Split(new char[] { ',', '&', '!', '*', ' ' }, StringSplitOptions.RemoveEmptyEntries);
    string[] result = new string[arrStr.Length];
    for (int i = 0; i < arrStr.Length; i++)
    {
        result[i] = arrStr[i];
    }
    return result;
}

void MainTask(string[] inputArray)
{
    int count = inputArray.Length;
    int i = 0;
    int index = 0;
    while (i < count)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[index] = inputArray[i];
            index = index + 1;
        }
        i = i + 1;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {        
        Write($"{array[i]} ");        
    }   

}