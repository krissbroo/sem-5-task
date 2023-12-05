//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

int ReadInt(string text)
{
System.Console.Write(text);
return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
int[,] tempMatrix = new int[row, col];
Random rand = new Random();

for (int i = 0; i < tempMatrix.GetLength(0); i++)
{
for (int j = 0; j < tempMatrix.GetLength(1); j++)
{
tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
}
}
return tempMatrix;
}

void PrintMatrix(int[,] matrixForPrint)
{
for (int i = 0; i < matrixForPrint.GetLength(0); i++)
{
for (int j = 0; j < matrixForPrint.GetLength(1); j++)
{
System.Console.Write(matrixForPrint[i, j] + "\t");
}
System.Console.WriteLine();
}
}

// ------------------------------------------

int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");
int row = ReadInt("введите номер строки массива ");
int col = ReadInt("введите номер столбца массива ");
// Заполнение массива
int[,] matrix = GenerateMatrix(rows, cols, 1, 10);

PrintMatrix(matrix);


   if (row > 0 | row < matrix.GetLength(0) - 1 | col > 0 | col < matrix.GetLength(1) - 1)
{
Console.WriteLine("Значение элемента массива = {0} ", matrix[row,col]);
}
    else
{
    Console.WriteLine("Элемент не существует  ");
}
