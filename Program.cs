// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] Array = { "abc", "abcd", "ab", "abcdf", "123r4t", "13" };
string[] newArray = new string[Array.Length];
var realSize = 0;
foreach (var value in Array)
{
    if (value.Length <= 3)
    {
        newArray[realSize] = value;
        realSize++;
    }
}

// В условии не написано вывести результат в терминал, поэтому нижние строки закомментировал.
// for (int i = 0; i < newArray.Length; i++)
//         Console.Write("{0} ", newArray[i]);
//       Console.WriteLine();
