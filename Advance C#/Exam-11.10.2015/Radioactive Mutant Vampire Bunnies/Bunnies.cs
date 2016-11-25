namespace Radioactive_Mutant_Vampire_Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Bunnies
    {
        static bool dead;
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int playerRow = 0;
            int playerCol = 0;
            bool won = false;

            List<List<char>> lair = new List<List<char>>();
            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();
                lair.Add(new List<char>(input));
                if (input.Contains("P"))
                {
                    playerRow = i;
                    playerCol = input.IndexOf('P');
                }
            }

            string commands = Console.ReadLine();
            for (int i = 0; i < commands.Length && dead == false && won == false; i++)
            {
                switch (commands[i])
                {
                    case 'U':
                        playerRow--;
                        break;
                    case 'R':
                        playerCol++;
                        break;
                    case 'D':
                        playerRow++;
                        break;
                    case 'L':
                        playerCol--;
                        break;
                }

                if (playerCol < 0 || playerRow < 0 || playerCol >= cols || playerRow >= rows)
                {
                    won = true;
                }
                else
                {
                    if (lair[playerRow][playerCol] == 'B')
                    {
                        dead = true;
                    }
                }

                BunnySpread(lair, playerRow, playerCol, won);
            }

            PrintLair(lair);
            if (won == true)
            {
                if (playerRow < 0) playerRow = 0;
                else if (playerRow >= rows) playerRow = rows - 1;
                else if (playerCol < 0) playerCol = 0;
                else if (playerCol >= cols) playerCol = cols - 1;
                Console.WriteLine("won: {0} {1}", playerRow, playerCol);
            }
            else if (dead == true)
            {
                Console.WriteLine("dead: {0} {1}", playerRow, playerCol);
            }
        }

        private static void PrintLair(List<List<char>> lair)
        {
            for (int i = 0; i < lair.Count; i++)
            {
                Console.WriteLine(lair[i].ToArray());
            }
        }

        private static void BunnySpread(List<List<char>> lair, int playerRow, int playerCol, bool won)
        {
            List<List<char>> temp = new List<List<char>>();
            for (int i = 0; i < lair.Count; i++)
            {
                temp.Add(new List<char>());
                for (int j = 0; j < lair[0].Count; j++)
                {
                    temp[i].Add('.');
                }
            }

            for (int i = 0; i < lair.Count; i++)
            {
                for (int j = 0; j < lair[i].Count; j++)
                {
                    if (lair[i][j] == 'B')
                    {
                        temp[i][j] = 'B';
                        if (i >= 1)
                        {
                            temp[i - 1][j] = 'B';
                        }
                        if (i < lair.Count - 1)
                        {
                            temp[i + 1][j] = 'B';
                        }
                        if (j >= 1)
                        {
                            temp[i][j - 1] = 'B';
                        }
                        if (j < lair[i].Count - 1)
                        {
                            temp[i][j + 1] = 'B';
                        }
                    }
                }
            }

            if (!won)
            {
                if (temp[playerRow][playerCol] != 'B')
                {
                    temp[playerRow][playerCol] = 'P';
                }
                else
                {
                    dead = true;
                }
            }

            for (int i = 0; i < lair.Count; i++)
            {
                for (int j = 0; j < lair[0].Count; j++)
                {
                    lair[i][j] = temp[i][j];
                }
            }        
        }
    }
}
