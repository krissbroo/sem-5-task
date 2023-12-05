// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// 4 3 1 => 4 6 2
// 2 6 9    2 6 9
// 4 6 2    4 3 1



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



int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");

// Заполнение массива
int[,] matrix = GenerateMatrix(rows, cols, 1, 10);

PrintMatrix(matrix);
Console.WriteLine(); 


for(int i = 0; i < matrix.GetLength(1); i++)
            {
                int change = matrix[matrix.GetLength(0) -1 , i];
                matrix[matrix.GetLength(0) -1, i] = matrix[0, i];
                matrix[0, i] = change;
            }
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }



        //  не могу понять как определить это действие в функцию 
        