Console.WriteLine(".Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1);

int[,,] arrayThreeDimensional(int row, int col, int dep, int min, int max) // функция создания 3D матрицы
{   int[,,] arrayThreeD = new int[row, col, dep];
    Random random = new Random();   
    for (int i = 0; i < arrayThreeD.GetLength(0); i++) 
    {
        for (int j = 0; j < arrayThreeD.GetLength(1); j++)
        {
            for (int k = 0; k < arrayThreeD.GetLength(2); k++)
                {
                    arrayThreeD[i,j,k] = random.Next(min, max); 
                }
        }
    }
    return arrayThreeD;
} 
 
void PrintArrayThreeDimensional(int[,,] arrayThreeD) // функция вывода матрицы на экран.
{
    for (int i = 0; i <  arrayThreeD.GetLength(0); i++)
    {
        Console.Write("|");                           // вывод разделителя элементов матрицы.
        for (int j = 0; j < arrayThreeD.GetLength(1); j++) 
        {
            for (int k = 0; k < arrayThreeD.GetLength(2); k++)
            {
            Console.Write("|");                       //вывод разделителя элементов матрицы.
            Console.Write($"{arrayThreeD[i, j, k],1}({i},{j},{k})|"); } // вывод на печать [i, j, k] - элемент матрицы, ({i},{j},{k}) - индексы, соответствующие элементу.
            }
              Console.WriteLine();    
        }
           
}        

int[,,] threeDarray= arrayThreeDimensional(2, 2, 2, 10, 100); // параменты матрицы.
PrintArrayThreeDimensional(threeDarray);