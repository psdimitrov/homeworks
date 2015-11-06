package com.company;

import java.util.Scanner;


public class HitTheTarget {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int target = sc.nextInt();
        if (target > 20) {
            for (int i = target-20; i <= 20; i++) {
                System.out.printf("%d + %d = %d\n",i ,target-i ,target);
            }
        }
        else if (target < 0){
            for (int i = 1; i <= target + 20; i++) {
                System.out.printf("%d - %d = %d\n",i ,i - target, target);
            }
        }
        else {
            for (int i = 1; i < target; i++) {
                System.out.printf("%d + %d = %d\n",i ,target-i ,target);
            }
            for (int i = target +1; i <= 20; i++) {
                System.out.printf("%d - %d = %d\n", i, i - target, target);
            }
        }
    }
}
