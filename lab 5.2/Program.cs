using System;

class MathOperations
{
    // Перевантажений метод додавання двох чисел
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Перевантажений метод додавання двох масивів чисел
    public static int[] Add(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            throw new ArgumentException("Arrays must have the same length.");
        }

        int[] result = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }

        return result;
    }

    // Перевантажений метод додавання двох матриць
    public static int[,] Add(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions.");
        }

        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        int[,] result = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    // Перевантажений метод додавання двох тензорів
    public static int[,,] Add(int[,,] tensor1, int[,,] tensor2)
    {
        if (tensor1.GetLength(0) != tensor2.GetLength(0) ||
            tensor1.GetLength(1) != tensor2.GetLength(1) ||
            tensor1.GetLength(2) != tensor2.GetLength(2))
        {
            throw new ArgumentException("Tensors must have the same dimensions.");
        }

        int depth = tensor1.GetLength(0);
        int rows = tensor1.GetLength(1);
        int columns = tensor1.GetLength(2);
        int[,,] result = new int[depth, rows, columns];
        for (int i = 0; i < depth; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                for (int k = 0; k < columns; k++)
                {
                    result[i, j, k] = tensor1[i, j, k] + tensor2[i, j, k];
                }
            }
        }

        return result;
    }

    // Додайте інші методи інших операцій, наприклад, віднімання, множення, тощо.
}

class Program
{
    static void Main()
    {
        // Приклад використання
        Console.WriteLine(MathOperations.Add(5, 10));
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] resultArray = MathOperations.Add(array1, array2);
        Console.WriteLine(string.Join(", ", resultArray));
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        int[,] resultMatrix = MathOperations.Add(matrix1, matrix2);
        Console.WriteLine($"{resultMatrix[0, 0]}, {resultMatrix[0, 1]}, {resultMatrix[1, 0]}, {resultMatrix[1, 1]}");
    }
}

