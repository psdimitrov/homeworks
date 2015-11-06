package com.company;

import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;


public class RandomizeNumbers {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        int m = sc.nextInt();

        int smaller =0;
        int bigger =0;
        if (n==m) {
            System.out.println(n);
            return;
        }
        else if (n > m) {
            smaller = m;
            bigger = n;
        }
        else {
            smaller = n;
            bigger = m;
        }
        int[] numbers = new int[bigger - smaller +1];
        for (int i=0; i<=bigger-smaller; i++) {
            numbers[i] = i+smaller;
        }
        shuffle(numbers);
        System.out.println(Arrays.toString(numbers));
    }
    static void shuffle(int[] array) {
        Random rnd = new Random();

        int n = array.length;
        for (int i = 0; i < n; i++) {
            // Exchange array[i] with random element in array[i … n-1]
            int r = i + rnd.nextInt( n - i);
            int temp = array[i];
            array[i] = array[r];
            array[r] = temp;
        }
    }
}

