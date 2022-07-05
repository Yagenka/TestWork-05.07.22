// Создание массива исходных строк
// Основная задача
// Печать массива

Console.Write("Введите количество элементов в массиве: ");
int len = Convert.ToInt32(Console.ReadLine());
string[] inputstring = CreateArray(len);
FillArray(inputstring);
PrintArray(inputstring);
Console.WriteLine();
string[] outstring = MainExample(inputstring);
PrintArray(outstring);

string[] CreateArray(int count)
{
    return new string[count];
}

void FillArray(string[] inputArray)
{
    int len = inputArray.Length;
    Console.WriteLine($"Введите {len} элементов массива");
    for (int i = 0; i < len; i++)
    {
        inputArray[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.WriteLine($"{array[i]}");
    }

}

string[] MainExample(string[] inputArray)
{
    int count = inputArray.Length;
    int index = 0;
    int i = 0;
    while (i < count)
    {
        if (inputArray[i].Length <= 3)
        {
            index++;
        }
        i++;
    }
    string[] outputArray = new string[index];
    count = inputArray.Length;
    index = 0;
    i = 0;
    while (i < count)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[index] = inputArray[i];
            index++;
        }
        i++;
    }
    return outputArray;
}