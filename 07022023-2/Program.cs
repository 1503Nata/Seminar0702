Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine();


Console.WriteLine("Создан массив:  ");

int[,] ArrayForSum (int row, int col, int min, int max) // функция создания массива по заданным параматрам row, col, min, max.
{
    int[,] arrForSum = new int[row, col];
    Random random = new Random();
    for (int i = 0; i < arrForSum.GetLength(0); i++)
    {
        for (int j = 0; j < arrForSum.GetLength(1); j++)
        {
            arrForSum[i,j] = random.Next(min, max +1); 
        }
    }
    return arrForSum;
}

void PrintArray (int [,] arrForSum) // Функция вывода массива на экран.
{for (int i=0; i<arrForSum.GetLength(0); i++)
      {
        for (int j=0; j<arrForSum.GetLength(1); j++)
        Console.Write($"{arrForSum[i, j]} \t"); // Вывод массива с заданным табулятором интервалом между элекментами.
        Console.WriteLine();
      }

}
int i=0;
int j=0;
void MinSumRow(int[,] arrForSum) // функция вычисления индекса строки с минимальной суммой элементов.
{   int index = 0;  
    for (int i = 0; i < arrForSum.GetLength(0); i++)
    {
        int sum = 0;
        int minSum = 0;
        for (int j = 0; j < arrForSum.GetLength(1); j++) //
        {
            sum += arrForSum[i, j]; // сумма элементов i строки
            if (sum <= minSum) sum = minSum; // если сумма i строки меньше или равна minSum, то sum(i) становится минимальной и проверяется строка i+1. 
            index = i; 
        }
        
    }
   Console.Write($"Строка № {index} c минимальной суммой элементов. ");
}
int[,] arraySum = ArrayForSum(5, 6, 0, 10);
PrintArray(arraySum); // выаод на экран первоначального массива
Console.WriteLine();
MinSumRow(arraySum); // вызов функции вычисления индекса сроки с мин. суммой элекментов.
