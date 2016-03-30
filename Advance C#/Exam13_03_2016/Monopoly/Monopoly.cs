using System;
using System.Linq;

class Monopoly
{
    static void Main()
    {
        var tokens =
            Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        var rows = tokens[0];
        var cols = tokens[1];

        var money = 50;
        var hotelsCount = 0;

        var monopolyMatrix = new char[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            var line = Console.ReadLine();
            for (int j = 0; j < cols; j++)
            {
                monopolyMatrix[i, j] = line[j];
            }
        }
        var turn = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int col;
                if (i % 2 == 0)
                {
                    col = j;
                }
                else
                {
                    col = cols - j - 1;
                }

                var currentPosition = monopolyMatrix[i, col];

                var inJail = false;
                switch (currentPosition)
                {
                    case 'H':
                        Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}", money, ++hotelsCount);
                        money = 0;
                        break;
                    case 'J':
                        Console.WriteLine("Gone to jail at turn {0}", turn);
                        inJail = true;
                        break;
                    case 'F':
                        break;
                    case 'S':
                        var spentMoney = (i + 1) * (col + 1);
                        if (money < spentMoney)
                        {
                            Console.WriteLine("Spent {0} money at the shop.", money);
                            money = 0;
                        }
                        else
                        {
                            Console.WriteLine("Spent {0} money at the shop.", spentMoney);
                            money -= spentMoney;
                        }
                        break;
                }

                var enterTurn = turn;
                do
                {
                    if (turn - enterTurn == 2)
                    {
                        inJail = false;
                    }

                    money += hotelsCount * 10;
                    turn++;
                }
                while (inJail);                                        
            }
        }

        Console.WriteLine("Turns " + turn);
        Console.WriteLine("Money " + money);
    }
}
