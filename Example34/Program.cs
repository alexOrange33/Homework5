// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

System.Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size);
System.Console.WriteLine($"[{String.Join(", ", array)}]");
System.Console.WriteLine($"Количество четных элементов в массиве: {EvenNumbers(array)}");

//-----metod------

int[] GetArray(int size)
{
    int[] array = new int[size];
    for(int i =0; i < size; i++)
    {
        array[i] =new Random().Next(100,1000);
    }
    
    return array;
}
int EvenNumbers(int[] array)
{
    int count = 0;
    foreach(int temp in array)
    {
        if(temp%2 == 0) count++;
    }
    return count;
}