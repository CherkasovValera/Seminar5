// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int N, int start, int end) // Генерация случайного массива
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
 
// int[] CreateArray()  // Формирование массива введеного пользователем
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }
 
// void ShowArray(int[] array) //Вывод МАССИВА! на экран.
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
 
//  Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве"); // Опрос для введения случайного массива
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());
 
//int[] myRandomArray = CreateRandomArray(num, min, max); // Обращение к методу вывода на экран случайного массива
// ShowArray(myRandomArray);
// Console.WriteLine("-------");
// int[] myArray = CreateArray(); // Обращение к методу для вывода заданного пользователем массива
// ShowArray(myArray);

int[] CreateRandomArray(int N, int start, int end) // Генерация случайного массива
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
void ShowArray(int[] array) //Вывод МАССИВА! на экран.
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
 Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве"); // Опрос для введения случайного массива
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());


int[] iArray = CreateRandomArray(10, 100, 999); // Обращение к методу вывода на экран случайного массива
ShowArray(iArray);
int sum=0;
for (int i = 0; i < iArray.Length; i++)
{
        if (iArray[i] %2== 0)
       {
        sum += 1;
       } 
}
Console.WriteLine($"Количество четных чисел = {sum}");