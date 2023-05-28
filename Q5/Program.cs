namespace Q5;
class Program
{

    static bool IsSymmetrical(int[,] mat)
    {
        int n = mat.GetLength(0);

        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                if (mat[i, j] != mat[n - 1 - i, j] || mat[i, j] != mat[i, n - 1 - j] || mat[i, j] != mat[n - 1 - i, n - 1 - j])
                {
                    return false;
                }
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
    static void Main(string[] args)
    {
        int[,] matrix = {
        { 1, 2, 2, 1 },
        { 3, 3, 3, 3 },
        { 3, 3, 3, 3 },
        { 1, 2, 2, 1 }
    };

        bool isSymmetrical = IsSymmetrical(matrix);
        PrintMat(matrix);
        Console.WriteLine("Is the matrix symmetrical? " + isSymmetrical);

    }
}
