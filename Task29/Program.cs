// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

int [] array = new int [8];

void PrintArray(int[] array)
{
    int count = array.Length-1;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[count++]}");
}
void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(-1000, 1000);
        index++;
    }
}
Console.WriteLine("");
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");

// for reviewer's convenience was used interval up to 1000 (to avoid giant numbers)
