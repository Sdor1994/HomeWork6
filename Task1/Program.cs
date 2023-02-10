/// Написать программу, которая обменивает элементы первой строки и последней строки

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
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Измененная матрица: ");

    for (int j = 0; j < width; j++)
    {
       double temp= matrix [0, j];
        matrix[0, j]=matrix[length - 1, j];
        matrix[length - 1, j] = temp;
    }
    Console.WriteLine();

for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();