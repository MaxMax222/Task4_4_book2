namespace Q4;
class Program
{
    static bool IsDiagonalMatrix(int[,] mat)
    {
        int n = mat.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            if (!(mat[i, i] == 1 && mat[i, i] == mat[i, n - 1 - i]))
            {
                return false;
            }
        }
        return true;
    }
    static void PrintMat(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void InitMat(int[,] matrix)
    {
        Random rand = new Random();

        int size = matrix.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = rand.Next(2);
            }
        }
    }
    static void Main(string[] args)
    {
        int[,] mat = new int[5, 5];
        InitMat(mat);
        PrintMat(mat);
        if (IsDiagonalMatrix(mat))
        {
            Console.WriteLine($"the matrix is a diagonal matrix");

        }

    }
}
