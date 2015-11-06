package com.company;


import java.util.Scanner;

public class OddAndEvenPairs {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] str = sc.nextLine().split("\\s+");
        if (str.length%2!=0) {
            System.out.println("Invalid length");
            return;
        }
        int[] numbers = new int[str.length];
        int i = 0;
        for (String string : str) {
            numbers[i] = Integer.parseInt(string);
            i++;
        }
        for (i = 0; i < numbers.length; i+=2) {
            if ((numbers[i] + numbers[i+1])%2!=0) {
                System.out.printf("%d, %d -> different\n",numbers[i],numbers[i+1]);
            }
            else {
                if (numbers[i]%2==0) {
                    System.out.printf("%d, %d -> both are even\n",numbers[i],numbers[i+1]);
                }
                else {
                    System.out.printf("%d, %d -> both are odd\n",numbers[i],numbers[i+1]);
                }
            }
        }
    }
}
