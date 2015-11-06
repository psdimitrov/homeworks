package com.company;

import java.util.Locale;
import java.util.Scanner;


public class CalculateExpression {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);
        Scanner sc = new Scanner(System.in);
        double a = sc.nextDouble();
        double b = sc.nextDouble();
        double c = sc.nextDouble();
        double f1 = f1(a, b, c);
        double f2 = f2(a, b, c);

        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f", f1, f2, Math.abs(average(a, b, c) - average(f1, f2)));
    }
    static double f1(double a, double b, double c) {
        double result = (a * a + b * b)/(a * a - b * b);
        result = Math.pow(result, (a + b + c)/Math.sqrt(c));
        return result;
    }
    static double f2(double a, double b, double c) {
        double result = (a * a + b * b - c * c * c);
        result = Math.pow(result, (a - b));
        return result;
    }
    static double average(double... args) {
        double sum = 0;

        for ( double elem : args){
              sum += elem;
        }
        return sum/args.length;
    }
}
