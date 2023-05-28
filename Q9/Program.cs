namespace Q9;
class Program
{
    static void ChangeAboveWithUnder(int[,] mat)
    {
        int n = mat.GetLength(0), temp;
        for (int r = 0; r < n; r++)
        {
            for (int c = 1; c < r; c++)
            {
                temp = mat[r, c];
                mat[r, c] = mat[c, r];
                mat[c, r] = temp;
            }
        }
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
                matrix[i, j] = rand.Next(10);
            }
        }
    }
    static void Main(string[] args)
    {
        int[,] mat = new int[5, 5];
        InitMat(mat);
        PrintMat(mat);
        Console.WriteLine($"\n");
        Console.WriteLine($"\n");
        ChangeAboveWithUnder(mat);
        PrintMat(mat);
    }
}
