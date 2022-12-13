// // адача 36
// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// // В качестве примеров:

// // [3, 7, 23, 12] -> 19

// // [-4, -6, 89, 6] -> 0
// void arrayRandom(int[] array)
// {   
//     Console.Write($"Массив заполненный случайными числами = ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-99, 100);
//         Console.Write($"{array[i]} ");
//     }
//         Console.WriteLine();
// }
// void arraySumNotEven(int[] array)
// {   
//     Console.Write($"Нужные нам элементы = ");
//     int sum = 0;
//     for (int i = 1; i < array.Length; i+=2)
//     {
//         sum = sum + array[i];
//         Console.Write($"{array[i]} ");
//     }    
//         Console.WriteLine();
//         Console.Write($"Cумма элементов, стоящих на нечётных позициях {sum} ");
// }
// Console.WriteLine("Введите количество элементов массива ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// arrayRandom(array);
// arraySumNotEven(array);


// // Задача №34
// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// // В качестве примера:

// // [345, 897, 568, 234] -> 2

//  Console.WriteLine("Введите количество элементов в массиве:");
//     Random rnd = new Random();
//  int j = 0;
//  bool numberCheck = int.TryParse(Console.ReadLine(),out int j_size);
//   if (numberCheck)
//    {
//   int[] j_array = new int[j_size];
//   for (int i = 0; i < j_size; i++)
//   {
//     j_array[i] = rnd.Next(100, 999);
//     if (j_array[i] % 2 == 0) j++;
//   }  
//     Console.WriteLine("[" + String.Join(", ", j_array) + "] -> " + j);

//   }
//  else Console.WriteLine("не число");