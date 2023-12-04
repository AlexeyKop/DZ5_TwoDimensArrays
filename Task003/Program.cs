// Задача  3: Задайте  прямоугольный  двумерный  массив. Напишите  программу,  
//которая  будет  находить  строку  с наименьшей суммой элементов.
void InputMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,11);
        }
    }
}

void PrintMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }

}

int [] SumStrArray(int [,] matrix){
    int [] str_array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa += matrix[i, j];       
        }
        str_array[i] = summa;
    }
    return str_array;
}

int MinIndex(int [] min_array){
    int min = min_array[0];
    int minindex = 0;
    for (int i = 0; i < min_array.Length - 1; i++){
        if (min > min_array[i]){
            min = min_array[i];
            minindex = i;
        }        
    }
    return minindex;
}

Console.Clear();
Console.Write("Введ размеры двумерн массива: ");
int [] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

int [,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Begining array: ");
PrintMatrix(matrix);
int [] SumStringArray = SumStrArray(matrix);
Console.WriteLine($"Сум строк в виде одномерн массива: [{string.Join(", ", SumStringArray)}]");
Console.WriteLine($"Index of str with min sum: {MinIndex(SumStringArray)} ");

