namespace Assignment5._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the matrix:");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe matrix is:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int rightDiagonalSum = 0;
            for (int i = 0; i < size; i++)
            {
                rightDiagonalSum += matrix[i, size - 1 - i];
            }

            Console.WriteLine($"\nThe sum of the right diagonal is: {rightDiagonalSum}");
        }
    }
}
