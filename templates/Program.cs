string[] array = new string[] { "hello", "2", "world", ":-)" };
string[] newArray = new string[array.Length];

void CheckArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) newArray[i] = array[i];
    }
}

CheckArray(array);

void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != "") Console.Write($"{arr[i]} ");
    }
}

PrintArr(newArray);