/// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

void Print(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int length= ReadInt("Введите колличество строк: ");
int width= ReadInt("Введите колличество столбцов: ");
int left= ReadInt("Введите левый предел чисел: ");
int right= ReadInt("Введите правый предел чисел: ");

double[,] matrix = new double[length, width];
Console.WriteLine();
Console.WriteLine("Изначальная матрица: ");
Random random = new Random();
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
        matrix[i, j] = random.Next(left,right);
    }
    Console.WriteLine();
}
Print(matrix);


Console.WriteLine("Отсортированная матрица: ");
Console.WriteLine();

double num;

for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width-1; j++)
    {
        for (int k = 0; k < width-1; k++)
         if (matrix[i,k]<matrix[i,k+1])
         {
            num=matrix[i,k];
            matrix[i,k]=matrix[i,k+1];
            matrix[i,k+1]=num;
         }
    }   
} 

Print(matrix);
