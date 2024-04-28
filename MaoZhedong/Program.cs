namespace MaoZhedong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] ticket = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    ticket[i, j] = int.Parse(row[j]);
                }
            }
            int diagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int aboveDiagonalSum = 0;
            int belowDiagonalSum = 0;
            int evenOnDiagonalSum = 0;
            int evenOuterRowSum = 0;
            int oddOuterColSum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        diagonalSum += ticket[i, j];
                        if (ticket[i, j] % 2 == 0)
                        {
                            evenOnDiagonalSum += ticket[i, j];
                        }
                    }
                    if (i + j == n - 1)
                    {
                        secondaryDiagonalSum += ticket[i, j];
                    }
                    if (i < j)
                    {
                        aboveDiagonalSum += ticket[i, j];
                    }
                    if (i > j)
                    {
                        belowDiagonalSum += ticket[i, j];
                    }
                    if (i == 0 || i == n - 1)
                    {
                        if (ticket[i, j] % 2 == 0)
                        {
                            evenOuterRowSum += ticket[i, j];
                        }
                    }
                    if (j == 0 || j == n - 1)
                    {
                        if (ticket[i, j] % 2 != 0)
                        {
                            oddOuterColSum += ticket[i, j];
                        }
                    }
                }
            }
            if (diagonalSum == secondaryDiagonalSum && aboveDiagonalSum % 2 == 0 && belowDiagonalSum % 2 != 0)
            {
                double totalWinning = (belowDiagonalSum + evenOnDiagonalSum + evenOuterRowSum + oddOuterColSum) / 4.0;
                Console.WriteLine($"YES\nThe amount of money won is: {totalWinning:F2}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
