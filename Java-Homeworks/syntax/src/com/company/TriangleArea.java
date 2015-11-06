package com.company;

import java.util.Scanner;


public class TriangleArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int aX = sc.nextInt();
        int aY = sc.nextInt();
        int bX = sc.nextInt();
        int bY = sc.nextInt();
        int cX = sc.nextInt();
        int cY = sc.nextInt();
        System.out.println(triangleArea(aX,aY,bX,bY,cX,cY));

    }
    public static int triangleArea(int aX, int aY, int bX, int bY, int cX, int cY) {
        return Math.abs((aX * (bY - cY) + bX * (cY - aY) + cX * (aY- bY))/2);
    }
}
