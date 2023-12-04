// Задача  1: Напишите  программу,  которая  на  вход принимает  позиции  элемента  
//в  двумерном  массиве,  и возвращает  значение  этого  элемента  
//или  же  указание, что такого элемента нет.

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

int FindElemArray (int x, int y, int [,] matrix){
    int findelem = 0;    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i  == x)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j  == y)
            findelem = matrix[i, j];       
        }        
    }
    return findelem;
}

Console.Clear();
Console.Write("Введ размеры двумерн массива через пробел: ");
int [] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Begining array: ");
PrintMatrix(matrix);
Console.WriteLine("Введ кординаты элемента в двумерн массиве через Enter: ");
int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);

int n = FindElemArray(x, y, matrix);
if (n != 0)
    Console.WriteLine($"Элемент с координатами {x}, {y}: {FindElemArray(x, y, matrix)} ");
else
    Console.WriteLine("Такого элемента не существует");
