// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21

System.Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size);
System.Console.WriteLine($"[{String.Join(" | ",array)}]");
System.Console.WriteLine($"Массив произведений пар чисел: [{String.Join(" | ",GetArray2(array))}]");



//-----metod-------
int[] GetArray(int size)
{
    int[] array = new int[size];
    for(int i =0; i < size; i++)
    {
        array[i] =new Random().Next(100);
    }
    
    return array;
}

int[] GetArray2(int[] array)
{
    int size;
    if(array.Length%2 == 0)
    {
        size = array.Length/2;
    }  
    else
    {
        size = array.Length/2+1;
    }  
    int[] result = new int[size];
    for(int i = 0;i < size;i++)
    {
        result[i] = array[i] * array[(array.Length-1)-i];
    }
    if(array.Length%2 != 0) 
    {
        result[result.Length-1] = array[array.Length/2];
    }
    return result;
}