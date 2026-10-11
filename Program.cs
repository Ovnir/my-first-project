Random r = new Random();
int rows = ReadNumber(1, 5, "Введите количество строк от 1 до 5: ");
int[] Lengths = new int[rows];
for (int i = 0; i < rows; i++)
{
    Lengths[i] = ReadNumber(2, 6, $"Введите длину {i + 1} строки от 2 до 6: ");
}
int[][] mas = new int[rows][];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new int[Lengths[i]];
}
Fill(mas, r);
var result = Analyze(mas);
Print(mas, result.maxIn, result.min, result.sum);
int ReadNumber (int min, int max , string prompt)
{
   while (true)
{
    Console.Write(prompt);
    try
    {
        int s = Convert.ToInt32(Console.ReadLine()); 
        if ( s >= min && s <= max)
        return s;
        else
        {
        Console.WriteLine($"Число должно быть от {min} до {max}.");
        continue;
        }
    }
    catch
    {
        Console.WriteLine("Это не цифра. Попробуйте снова.");
    }
}
}
void Fill(int[][] arr, Random rnd)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr[i].Length; j++)
        {
            arr[i][j] = rnd.Next(1, 10);
        }
    }
}
(int min, int[] maxIn, int sum) Analyze (int[][] mass)
{
    int sum = 0;
    int min = mass[0][0];
    int[] maxIn = new int[mass.Length];
    for (int i = 0; i < mass.Length; i++)
    {
        int max = mass[i][0];
        for (int j = 0; j < mass[i].Length; j++)
        {
            if (min > mass[i][j])
                min = mass[i][j];
            if (max < mass[i][j])
                max = mass[i][j];
            sum += mass[i][j];
        }
        maxIn[i] = max;
    }
    return (min, maxIn, sum);
}
void Print(int[][] jagged, int[] maxIn, int min, int sum)
{
    for (int i = 0; i < jagged.Length; i++)
    {
        Console.Write($"Массив {i}:");
        for (int j = 0; j < jagged[i].Length; j++)
        {
            Console.Write(" " + jagged[i][j]);
        }
        Console.WriteLine(" | максимум: " + maxIn[i]);
    }
    Console.WriteLine($"Сумма массива: {sum}");
    Console.WriteLine($"Минимальное число массива: {min}");
}
