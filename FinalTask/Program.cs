void WordCutter(string[] array1, string[] array2)
{
    for (int i = 0, c = 0; i < array1.Length; i++)
    {
        if (array1[i].Length<=3)
        {
            array2[c] = array1[i];
            c++;
        }
        
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите массив строк через пробел");
string str = Console.ReadLine();
string[] array1 = str.Split(' ');
string[] array2 = new string[array1.Length];

WordCutter(array1, array2);
PrintArray(array2);