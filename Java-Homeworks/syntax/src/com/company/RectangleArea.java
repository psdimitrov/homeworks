package com.company;

import java.util.Scanner;

public class RectangleArea {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        int b = sc.nextInt();
        System.out.println(rectangleArea(a, b));
    }
    static int rectangleArea(int a, int b) {
        return a*b;
    }
}
