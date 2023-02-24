using System.Drawing;

Start();

void Start()
{
    while (true)
    {


        System.Console.WriteLine("\n54) \r\nЗадача 54: Задайте двумерный массив. \r\nНапишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        System.Console.WriteLine("\n56) \r\nЗадача 56: Задайте прямоугольный двумерный массив. \r\nНапишите программу, которая будет находить строку с наименьшей суммой элементов.");
        System.Console.WriteLine("\n58) \r\nЗадача 58: Задайте две матрицы. \r\nНапишите программу, которая будет находить произведение двух матриц.");
        System.Console.WriteLine("\n60) \r\nЗадача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. \r\nНапишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

        System.Console.WriteLine("\n0) End");

        int numTask = EnterNumber("\ntask");

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

void crossPoint(double b1, double k1, double b2, double k2) // функция по определению точки пересечения
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    if (k1 == k2)
    {
        Console.WriteLine($"\nCurent lines dosen't cross.");
        return;
    }

    Console.WriteLine($"\nPoint of cross is ({x};{y})\n");
}

int Fibonachi(int n) // функция по посторению ряда чисел фибоначи
{
    if (n == 1 || n == 2) return 1;
    else return Fibonachi(n - 1) + Fibonachi(n - 2);
}

double EnterDoubleNumber(string number) // функция для ввода вещественного значения пользователем
{
    Console.Write($"Enter {number}: ");
    double num = Convert.ToInt32(Console.ReadLine());
    return num;
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


double[,] GetDoubleMatrix(int rows, int columns, int minValue, int maxValue)
{
    double[,] matrix = new double[rows, columns];

    Random rdn = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Math.Round(rdn.Next(minValue, maxValue + 1) + rdn.NextDouble(), 2);
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


void PrintDoubleMatrix(double[,] matrix)
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

void CheckPosition(int[,] matrix) // проверяет по координатам есть такое значение в матрице или нет.
{

    int X = EnterNumber("Enter row index");
    int Y = EnterNumber("Enter column index");

    if (X >= matrix.GetLength(0) || Y >= matrix.GetLength(1))
    {
        System.Console.WriteLine("\nYou out of matrix");
    }
    else

    {
        System.Console.WriteLine($"\nOn position {X}.{Y} stay number {matrix[X, Y]}");
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
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i, j + 1] > matrix[i, j])
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[i, j + 1];
                matrix[i, j + 1] = matrix[i, j];
            }
        }
    }
}