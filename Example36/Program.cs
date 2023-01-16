// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. 
// (позиции - это индексы, нечетные индексы это 1,3,5 и тд)

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

System.Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size);
System.Console.WriteLine($"[{String.Join(" | ",array)}]");
System.Console.WriteLine("Сумма элементов с нечетными индексами равна: "+OddNumbersSum(array));

//-------metod-------
int[] GetArray(int size)
{
    int[] array = new int[size];
    for(int i =0; i < size; i++)
    {
        array[i] =new Random().Next(100);
    }
    
    return array;
}

int OddNumbersSum(int[] array)
{
    int summa = 0;
    for(int i = 1;i<array.Length;i+=2)
    {
        summa +=array[i];
    }
    return summa;
}