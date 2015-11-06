import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class _4_LongestIncreasingSequences {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int[] numbers = Arrays.stream(sc.nextLine().split(" ")).mapToInt(Integer ::parseInt).toArray();
        int length = 1;
        int index = 0;
        int maxLength = 0;

        if (numbers.length > 0) {
            System.out.printf("%d", numbers[0]);
        }
        for (int i = 1; i < numbers.length; i++) {
            if (numbers[i] > numbers[i-1]) {
                System.out.printf(" %d",numbers[i]);
                length++;
            } else {
                System.out.printf("\n%d",numbers[i]);
                if (length > maxLength) {
                    maxLength = length;
                    index = i - maxLength;
                }
                length = 1;
            }
        }
        if (length > maxLength) {
            maxLength = length;
            index = numbers.length-maxLength;
        }
        System.out.print("\nLongest:");
        for (int i = index; i < index + maxLength; i++) {
            System.out.printf(" %d",numbers[i]);
        }

    }
}