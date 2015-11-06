import java.util.Collections;
import java.util.Scanner;


public class _3_LargestSequenceOfEqualString {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] strings = sc.nextLine().split(" ");
        int length = 1;
        int index = 0;
        int maxLength = 0;

        for (int i = 1; i < strings.length; i++) {
            if (strings[i].equals(strings[i-1])) {
                length++;
            } else {
                if (length > maxLength) {
                    maxLength = length;
                    index = i-1;
                }
                length = 1;
            }
        }
        if (length > maxLength) {
            maxLength = length;
            index = strings.length-1;
        }
        System.out.println(String.join(" ", Collections.nCopies(maxLength, strings[index])));
    }
}
