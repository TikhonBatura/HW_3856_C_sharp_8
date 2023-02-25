using System.Drawing;

Start();

void Start()
{
    while (true)
    {


        System.Console.WriteLine("\nЗадача 54: Задайте двумерный массив. \r\nНапишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        System.Console.WriteLine("\nЗадача 56: Задайте прямоугольный двумерный массив. \r\nНапишите программу, которая будет находить строку с наименьшей суммой элементов.");
        System.Console.WriteLine("\nЗадача 58: Задайте две матрицы. \r\nНапишите программу, которая будет находить произведение двух матриц.");
        System.Console.WriteLine("\nЗадача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. \r\nНапишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

        System.Console.WriteLine("\n0) End");

        int numTask = EnterNumber("\nВведите номер задания: ");

        switch (numTask)
        {
            case 0: return; break;



            case 54:
                Console.Clear();

                int Rows = EnterNumber("Enter row size: ");
                int Colums = EnterNumber("Enter colums size: ");

                int minValue = EnterNumber("\nEnter MinValue for array");
                int maxValue = EnterNumber("Enter MaxValue for array");


                var matrix = GetMatrix(Rows, Colums, minValue, maxValue);

                PrintMatrix(matrix);
                Console.WriteLine();
                SortMatrixRows(matrix);
                PrintMatrix(matrix);
                Console.WriteLine();
                break;

            case 56:
                Console.Clear();


                Rows = EnterNumber("Enter row size: ");
                Colums = EnterNumber("Enter colums size: ");

                minValue = EnterNumber("\nEnter MinValue for array");
                maxValue = EnterNumber("Enter MaxValue for array");


                matrix = GetMatrix(Rows, Colums, minValue, maxValue);
                System.Console.WriteLine();
                PrintMatrix(matrix);
                Console.WriteLine();

                FindMinSumRows(matrix);
                Console.WriteLine();


                break;


            case 58:
                Console.Clear();



                break;


            case 60:
                Console.Clear();


                break;


        }
    }
}






int EnterNumber(string number) // функция для ввода целочисленного значения пользователем
{
    Console.Write($"{number}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int[] CreateArray(int size, int minValue, int maxValue) // функция по заполнению массива целочисленными значениями
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void MidSumInEachColumn(int[,] matrix)  // метод для подсчета среднего арифмитического в каждой колонке
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += matrix[i, j];
        }
        System.Console.WriteLine($"\nMiddle sum of column {j} = {sum / rows}");
    }
}


void SortMatrixRows(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }

            }

        }
    }

}

void FindMinSumRows(int[,] matrix)
{
    int rowMinSum = 0;
    int rowMinSumIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }

        System.Console.WriteLine($"In row {i+1} sum = {rowSum}");

        if (i == 0)
        {
            rowMinSum = rowSum;
            rowMinSumIndex = i;
        }    
        else if (rowSum < rowMinSum)
        {
            rowMinSum = rowSum;
            rowMinSumIndex = i+1;
        
        }
            
    }
    System.Console.WriteLine($"\nMinimal sum in row {rowMinSumIndex}");
}
    
