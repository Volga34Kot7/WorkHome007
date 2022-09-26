// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца ");
int[,] numbers = new int[6, 8];
CreateMatrixRndInt(numbers);
PrintMatrix(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
void CreateMatrixRndInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}




// Console.Clear();
// int[,] CreateMatrixRndInt(int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 11);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2}, ");
//             else Console.Write($"{matrix[i, j],2} ");
//         }
//         Console.WriteLine("]");
//     }
// }
// void SearchNumm(int[,] array, int pos)
// {
//     int row = pos / 10;
//     int column = pos % 10;
//     if ((row > 3) || (column > 4)) Console.WriteLine($"{pos} -> такого числа нет в массиве");
//     else Console.WriteLine($"Значение элемента равно {array[row - 1, column - 1]}"); 
// }

// int[,] array2D = CreateMatrixRndInt(3, 4);
// PrintMatrix(array2D);
// Console.Write($"Введите позицию элемента: ");
// int position = Convert.ToInt32(Console.ReadLine());
// SearchNumm(array2D, position);