package com.company;

import java.util.Scanner;


public class ConvertFromBase7 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String number = sc.nextLine();
        int baseSevenNumber = 0;
        char[] digits = number.toCharArray();
        for (int i = digits.length -1; i >= 0; i--) {
            int digit = Character.digit(digits[i],10);
            baseSevenNumber += digit * Math.pow(7,digits.length - i -1);
        }
        System.out.println(baseSevenNumber);

    }
}
