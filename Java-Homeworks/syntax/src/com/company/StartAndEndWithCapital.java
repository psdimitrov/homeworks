package com.company;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by AAAA on 21.10.2015 ã..
 */
public class StartAndEndWithCapital {
    public static void main(String[] args) {

        String[] array = {"GoshO", "blabla","NqmaSm1saL", "KvoStaA"};


        for (String string:array) {
            if (string.matches("^[A-Z][a-zA-Z]*[A-Z]$")) {
                System.out.printf("%s ",string);
            }
        }
    }
}
