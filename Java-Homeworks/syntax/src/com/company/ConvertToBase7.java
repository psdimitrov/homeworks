package com.company;

import java.util.Scanner;


public class ConvertToBase7 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int number = sc.nextInt();
        StringBuilder sb = new StringBuilder();
        while (number > 0) {
            int digit = number % 7;
            sb.append(digit);
            number /= 7;
        }
        System.out.println(sb.reverse());
    }
}
