/// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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
Console.WriteLine("Ваша матрица: ");
Random random = new Random();
for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
        matrix[i, j] = random.Next(left,right);
    }
}
Print(matrix);

Console.WriteLine();

double [] summma= new double[length];

for (int i = 0; i < length; i++)
{
    double sum=0;
    for (int j = 0; j < width; j++)
    {
        sum=sum+matrix[i,j];
    } 
 summma[i]= sum;
 Console.WriteLine("Сумма по строке "+(i+1)+" "+sum +" ");
}

double min =summma[0];
for(int i=0; i<length-1;i++)
{
    if (min>summma[i+1]) min=summma[i+1];
}
int n=0;
for(int i=0; i<length-1;i++)
{
    if (min==summma[i]) n=i+1;
}

Console.WriteLine();

Console.WriteLine("Миминмальная сумма элементов в " +n+ " строчке" );
