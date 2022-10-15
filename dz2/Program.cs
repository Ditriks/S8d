//  Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.Write("Сколько будет строк у массива? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("А столбцов? ");
int n = Convert.ToInt32(Console.ReadLine());
int range = 10;

int[,] array = new int[m,n];
CreateArray(array);
PrintArray(array);

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
int MinSumRow = 0;
int SumRow = SumRowElem(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRow = SumRowElem(array, i);
    if (SumRow > tempSumRow)
    {
        SumRow = tempSumRow;
        MinSumRow = i;
    }
}
Console.WriteLine($"\n{MinSumRow+1} - строкa с наименьшей суммой ({SumRow}) элементов ");

int SumRowElem(int[,] array, int i)
{
  int SumRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    SumRow += array[i,j];
  }
  Console.WriteLine(SumRow);
  return SumRow;
}
