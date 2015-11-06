package com.company;

import java.util.HashMap;
import java.util.Scanner;

public class MagicWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String str1 = sc.next("\\w+");
        String str2 = sc.next("\\w+");

        System.out.println(checkMagicWords(str1, str2));
    }

    private static boolean checkMagicWords(String str1, String str2) {
        if (str1.length()!= str2.length()) {
            return false;
        }
        HashMap<Character,Character> table = new HashMap<>();
        for (int i = 0; i < str1.length(); i++) {
            if (!table.containsKey(str1.charAt(i))) {
                table.put(str1.charAt(i),str2.charAt(i));
            }
            else {
                if (table.get(str1.charAt(i))!= str2.charAt(i)) {
                    return false;
                }
            }
        }
        long distinctValues = table.values().stream().distinct().count();
        if (table.size()!= distinctValues) {
            return false;
        }
        return true;
    }
}
