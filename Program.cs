// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] Array = { "abc", "abcd", "ab", "abcdf", "123r4t", "13" };
string[] FormArray(string[] Array, int N)
{
    string[] newArray = new string[Array.Length];
    var realSize = 0;
    foreach (var value in Array)
    {
        if (value.Length <= N)
        {
            newArray[realSize] = value;
            realSize++;
        }
    }
    return newArray;
}

string[] newArray = FormArray(Array, 3);
foreach (string i in newArray)
Console.Write($"{i} ");
