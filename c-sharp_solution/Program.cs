// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначально массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)']
// ["1234", "1567", "-2", "That's Jason Bourne"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] ArrayFilter(string[] myArray, int stringLength)
{
    string resString = "";
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= stringLength)
        {
            resString += myArray[i];
            resString += " ";
        }    
    }
    string[] resArray = resString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return resArray;
}

int maxStringLength = 3;
string[] myArray1 = {"hello", "2", "world", ":-)"};
string[] myArray2 = {"1234", "1567", "-2", "That's Jason Bourne"};
string[] myArray3 = {"Russia", "Denmark", "Kazan"};

Array.ForEach(ArrayFilter(myArray1, maxStringLength), (str) => Console.Write($"{str} "));
Console.WriteLine();
Array.ForEach(ArrayFilter(myArray2, maxStringLength), (str) => Console.Write($"{str} "));
Console.WriteLine();
Array.ForEach(ArrayFilter(myArray3, maxStringLength), (str) => Console.Write($"{str} "));
Console.WriteLine();