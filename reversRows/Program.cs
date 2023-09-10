﻿// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

var array = GenArray();
PrintArray(array);
System.Console.WriteLine(" ");
ChangeRows(array);
PrintArray(array);

void ChangeRows(int[,] array)
{
    int lastRow = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[lastRow, i];
        array[lastRow, i] = array[0, i];
        array[0, i] = temp;

    }

}


int[,] GenArray(int rows = 5, int cols = 6)
{
    Random random = new Random();
    int[,] array = new int[rows, cols];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(1, 50);
        } 
    }
    return array;
}

void PrintArray(int[,] array)
{
   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
        
    }
}



