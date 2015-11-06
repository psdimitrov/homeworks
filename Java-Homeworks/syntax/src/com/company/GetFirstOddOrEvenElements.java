package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;


public class GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] str = sc.nextLine().split("\\s+");

        List<Integer> numbers = new ArrayList<>();
        int i = 0;
        for (String string : str) {
            numbers.add(Integer.parseInt(string));
            i++;
        }
        String[] command = sc.nextLine().split("\\s+");

        if (command[2].equals("odd")) {
            System.out.println(getElements(numbers, Integer.parseInt(command[1]), 1));
        }
        else if (command[2].equals("even")) {
            System.out.println(getElements(numbers, Integer.parseInt(command[1]), 0));
        }
    }
    public static List<Integer> getElements(List<Integer> elements, int n, int odd) {
        List<Integer> resultElements = new ArrayList<>();
        int count = 0;
        for (int i = 0; i < elements.size(); i++) {
            if (count == n) break;
            if (elements.get(i)%2==odd) {
                resultElements.add(elements.get(i));
                count++;
            }
        }

        return resultElements;
    }
}
