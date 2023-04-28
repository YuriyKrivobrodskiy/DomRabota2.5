// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3,21 7,04 22,93 -2,71 78,24] -> 80,95

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

void mas(int size)
{
Random rand = new Random();
for (int i = 0; i < size; i++)
{
array[i] = rand.NextDouble();
Console.Write($"{array[i]:F2} ");
}

}

double raz(double[] array)
{
double min = array[0];
double max = array[0];
int i = 1;
while (i < array.Length)
{
if (max < array[i])
max = array[i];
if (min > array[i])
min = array[i];
i = i + 1;
}
return max-min;
}

mas(size);
Console.Write($"nРазница между максимальным и минимальным элементов массива равна: {raz(array):F2}");
