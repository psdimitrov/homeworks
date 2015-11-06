package com.company;


public class CharacterMultiplier {
    public static void main(String[] args) {
        System.out.println(charMultiplier("Gosho","Pesho"));
        System.out.println(charMultiplier("123","522"));
        System.out.println(charMultiplier("a", "aaaa"));
    }

    public static long charMultiplier(String str1, String str2) {
        if (str2.length() < str1.length()) {
            String temp = str1;
            str1 = str2;
            str2 = temp;
        }
        long result = 0;
        for (int i = 0; i <str1.length(); i++) {
            result += str1.charAt(i)*str2.charAt(i);
        }
        for (int i = str1.length(); i < str2.length(); i++) {
            result += str2.charAt(i);

        }
        return result;
    }
}
