namespace MinimumCols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            List<int> list = new List<int>();
            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }

            }
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");


                }


                Console.WriteLine();
            }
            int currSmall = 0;
            int small = int.MaxValue;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    currSmall = matrix[j, i];
                    if (currSmall < small)
                    {
                        small = currSmall;

                    }
                }
                list.Add(small);
                small = int.MaxValue;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
