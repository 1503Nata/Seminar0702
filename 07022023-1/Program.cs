Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine();

Random random = new Random();
Console.WriteLine("Создан массив:  ");
void FullArray (int [,] arrayArrangeToMin)             //Функция генерации массива. 
{for (int i=0; i<arrayArrangeToMin.GetLength(0); i++)
      { for (int j=0; j<arrayArrangeToMin.GetLength(0); j++)
           arrayArrangeToMin[i, j] = random.Next(1, 11); // массив случайных чисел от 1 до 10.
      } return;
}

void PrintArray (int [,] arrayArrangeToMin)             // Функция вывода массива на экран.
{for (int i=0; i<arrayArrangeToMin.GetLength(0); i++)
      {
        for (int j=0; j<arrayArrangeToMin.GetLength(0); j++)
        Console.Write($"{arrayArrangeToMin[i, j]} \t");         
        Console.WriteLine();
      }
        
}
int i, j;
void SortToMin(int[,] arrayArrangeToMin)                   //функция сортировки элементов строк массива от max к min.      
    {for (int i=0; i<arrayArrangeToMin.GetLength(0); i++)
        { for (int j=0; j<arrayArrangeToMin.GetLength(1); j++)
            {for (int f=0; f < arrayArrangeToMin.GetLength(1)-1; f++)
                 { if (arrayArrangeToMin[i, f] < arrayArrangeToMin[i, f+1]) // перебираем элементы строки i.
                    {
                        int temp = arrayArrangeToMin[i, f+1];           // принцип сортировки элементов 
                        arrayArrangeToMin[i, f+1] = arrayArrangeToMin[i, f];
                        arrayArrangeToMin[i, f] = temp;
                    }
                }
            }
        }
    }
int [,] arrayArrangeToMinimum = new int [3,3]; // задали параметры функции генерации массива
FullArray(arrayArrangeToMinimum);   // вызов функции генерации массива
PrintArray(arrayArrangeToMinimum);  // вызов функции вывода массива
Console.WriteLine();
Console.WriteLine("Массив, полученный в результате сортировки:  ");
SortToMin(arrayArrangeToMinimum);   // вызов функции сортировки массива
PrintArray(arrayArrangeToMinimum);  //вызов функции вывода массива после сортировки