package com.company;


import java.util.Locale;
import java.util.Scanner;


public class FormattingNumbers {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner sc = new Scanner(System.in);

        int a = sc.nextInt();
        double b = sc.nextDouble();
        double c = sc.nextDouble();
        String binaryA = String.format("%10s", Integer.toBinaryString(a)).replace(' ','0');
        String formated = String.format("|%-10x|%s|%10.2f|%-10.3f|", a, binaryA, b, c);
        System.out.println(formated.toUpperCase());
    }

}
