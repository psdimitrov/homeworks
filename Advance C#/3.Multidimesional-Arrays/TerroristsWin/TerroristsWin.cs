using System;
using System.Collections.Generic;
using System.Linq;

class TerroristsWin
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        List<int> bombStarts = new List<int>();
        List<int> bombEnds = new List<int>();
        int numberOfBombs = 0;
        int sum = 0;
        int index = 0;

        index = inputLine.IndexOf('|');
        
        while (index!=-1)
        {
            bombStarts.Add(index);
            bombEnds.Add(inputLine.IndexOf('|', index+1));
            index = inputLine.IndexOf('|',bombEnds[numberOfBombs] + 1);
            numberOfBombs++;
        }
        int[] bombPower = new int[numberOfBombs];
        for (int i = 0; i < numberOfBombs; i++)
        {
            for (int j = bombStarts[i]+1; j < bombEnds[i]; j++)
            {
                sum += inputLine[j];                
            }
            bombPower[i] = sum % 10;
            sum = 0;
        }
        char[] output = inputLine.ToArray();
        for (int i = 0; i < numberOfBombs; i++)
        {
            for (int j = bombStarts[i]-bombPower[i]; j <= bombEnds[i]+bombPower[i]; j++)
            {
                if (j >= 0 && j < output.Length)
                {
                    output[j] = '.';
                }
            }
        }
        Console.WriteLine(string.Join("",output));
    }
}

