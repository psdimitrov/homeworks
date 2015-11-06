package com.company;
import java.util.Scanner;

/**
 * Created by USER on 14.10.2015 ã..
 */
public class PrintCharacterTriangle {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int n ;
        n = Integer.parseInt(s.nextLine());
        for (int i=1;i<=n;i++){
            for (char ch = 'a';ch<i+97;ch++) {

                System.out.print(ch + " ");
            }
            System.out.println();
        }
        for (int i=n-1;i>0;i--){
            for (char ch='a';ch<i+97;ch++) {

                System.out.print(ch + " ");
            }
            System.out.println();

        }

    }
}
