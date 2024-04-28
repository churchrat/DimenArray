namespace AverageByRows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                double average = 0;
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    average += matrix[i, j];
                }
                average /= cols;
                Console.Write(Math.Round((average),2));
                Console.WriteLine();
            }
        }
    }
}
