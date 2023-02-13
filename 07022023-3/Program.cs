Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
Console.WriteLine();
int row, col;
Console.WriteLine("Введите количество строк матриц:  ");
      while (!Int32.TryParse(Console.ReadLine(), out row))
      Console.WriteLine("Данное число не соответствует формату. Введите целое число :  ");
Console.WriteLine("Введите количество столбцов матриц:  ");
      while (!Int32.TryParse(Console.ReadLine(), out col))
      Console.WriteLine("Данное число не соответствует формату. Введите целое число: ");
// if (row != col)
// Console.WriteLine("Число строк первой матрицы должно совпадать с числом столбцов второй матрицы. Иначе умножение невозможно.");
     
Random random = new Random();
Console.WriteLine("Созданы матрицы:  ");
void FullMatrix(int [,] matrix)
{for (int row=0; row<matrix.GetLength(0); row++)
      { for (int col=0; col<matrix.GetLength(1); col++)
           matrix[row, col] = random.Next(1, 11);
      } return;
}
void PrintMatrix(int [,] matrix)
{
      for (var row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col= 0; col < matrix.GetLength(1); col++)
            {   
                Console.Write("|");
                Console.Write(matrix[row, col].ToString().PadLeft(4) + "|");// оператор форматирования элементов матрицы ToString().PadLeft(4)
            }

            Console.WriteLine();
        }
    }
int[,]matrixOne = new int [row, col];
int[,]matrixTwo = new int [row, col];
FullMatrix(matrixOne);
FullMatrix(matrixTwo);

PrintMatrix(matrixOne);
Console.WriteLine();
PrintMatrix(matrixTwo);

int[,] MatrixMultiplication(int[,] matrixOne, int[,] matrixTwo) // создан метод для умножения матриц
{     int[,] matrixMult = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)]; // формируется новая матрица из строк первой матрицы и столбцов второй.
      for (int row = 0; row < matrixOne.GetLength(0); row++)
            {
            for (int col = 0; col < matrixTwo.GetLength(1); col++)
                  { matrixMult[row, col] = 0;
                    for (int k = 0; k < matrixOne.GetLength(1); k++)
                       {
                          matrixMult[row, col] += matrixOne[row, k] * matrixTwo[k, col]; //находим сумму произведений строк первой матрицы на столбцы второй поэлементно.
                       }
                  }
            }
      return matrixMult;
    }
int[,] matrixMultiplication = MatrixMultiplication(matrixOne, matrixTwo);
Console.WriteLine("Произведение матриц:");
PrintMatrix(matrixMultiplication);