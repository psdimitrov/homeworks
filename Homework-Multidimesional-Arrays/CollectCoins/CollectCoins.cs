using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        char[][] board = new char[4][];
        int row = 0;
        int col = 0;
        int money = 0;
        int wallsHit = 0;
        for (int i = 0; i < 4; i++)
        {
            board[i] = Console.ReadLine().ToArray();
        }
        string commands = Console.ReadLine();
        for (int i = 0; i < commands.Length; i++)
        {
            switch (commands[i])
            {
                case '<':
                    if (col == 0)
                    {
                        wallsHit++;
                        continue;
                    }
                    else
                    {
                        col--;
                    }                    
                    break;
                case '^':
                    if (row == 0 || col > board[row - 1].Length - 1)
                    {
                        wallsHit++;
                        continue;
                    }
                    else
                    {
                        row--;
                    }
                    break;
                case '>':
                    if (col == board[row].Length - 1)
                    {
                        wallsHit++;
                        continue;
                    }
                    else
                    {
                        col++;
                    }
                    break;
                case 'v':
                    if (row == 3 || col > board[row + 1].Length - 1)
                    {
                        wallsHit++;
                        continue;
                    }
                    else
                    {
                        row++;
                    }
                    break;
            }
            if(board[row][col]=='$')
            {
                money++;
            }
        }
        Console.WriteLine("Coins collected:{0}",money);
        Console.WriteLine("Walls hit:{0}",wallsHit);

    }
}
