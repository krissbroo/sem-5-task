// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2

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

void SumInLines(int[,] matrix)
        {
            int[] sumInLines = new int[matrix.GetLength(0)];

            Console.Write("\nСуммы элементов в каждой строке: ");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sumInLines[i] += matrix[i, j];
                }
                Console.Write($"{sumInLines[i]} ");
            }
            int minI = 0;
            for (int i = 0; i < sumInLines.Length; i++)
            {
                if (sumInLines[minI] > sumInLines[i]) minI = i;
            }
            Console.Write($"\n Наименьшая сумма элементов: {sumInLines[minI]}");
        }

       