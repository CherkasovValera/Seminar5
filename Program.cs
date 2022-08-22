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
// void ShowArray(int[] array) //Вывод МАССИВА! на экран.
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
//  Console.Clear();
// int[] iArray = CreateRandomArray(10, 100, 999); // Обращение к методу вывода на экран случайного массива
// ShowArray(iArray);
// int sum=0;
// for (int i = 0; i < iArray.Length; i++)
// {
//         if (iArray[i] %2== 0)
//        {
//         sum += 1;
//        } 
// }
// Console.WriteLine($"Количество четных чисел = {sum}");

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int N, int start, int end) // Генерация случайного массива
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
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
// Console.Clear();
// int[] arraynum = CreateRandomArray(10, -100, 100); // Обращение к методу вывода на экран случайного массива
// ShowArray(arraynum);
// int summa = 0;
// for (int i = 1; i < arraynum.Length; i = i + 2)
// {
//     summa += arraynum[i];
// }
// Console.WriteLine($"Сумма чисел на нечетных позициях = {summa}");


//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
//  В задаче задается массив целых чисел!

// int[] CreateRandomArray(int N, int start, int end) // Генерация случайного массива
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
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
// Console.Clear();
// int[] massarray = CreateRandomArray(10, -100, 100); // Обращение к методу вывода на экран случайного массива
// ShowArray(massarray);
// int min = 0;
// int max = 0;
// for (int i = 0; i < massarray.Length; i ++)
// {
//     if (massarray[i]<min) min=massarray[i];
//     else if(massarray[i]>max) max=massarray[i];
//  }
// Console.WriteLine($"Максимум {max}, Минимум {min}. Разница между максимальным и минимальным значениями = {max-min}");