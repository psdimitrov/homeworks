using System;

class MatrixSuffling
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
            int ass=int . Parse()
        }

        string input = Console.ReadLine();
        while (input != "END")
        {
            string[] commands = input.Split(' ');
            if (commands.Length != 5 || commands[0] != "swap")
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                int x1 = int.Parse(commands[1]);
                int y1 = int.Parse(commands[2]);
                int x2 = int.Parse(commands[3]);
                int y2 = int.Parse(commands[4]);
                if (x1 < 0 || x1 >= matrix.GetLength(0) || x2 < 0 || x2 >= matrix.GetLength(0) || y1 < 0 || y1 >= matrix.GetLength(1) || y2 < 0 || y2 >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;
                    PrintMatrix(matrix);
                }
            }
            input = Console.ReadLine();
        }     
    }

    static void PrintMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
