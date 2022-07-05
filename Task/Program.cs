// Создание массива исходных строк
// Основная задача
// Печать массива

Console.Write("Введите количество элементов в массиве: ");
int len = Convert.ToInt32(Console.ReadLine());
string[] newarray = CreateArray(len);
FillArray(newarray);


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

