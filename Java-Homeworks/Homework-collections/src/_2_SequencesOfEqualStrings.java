import java.util.Scanner;

public class _2_SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] strings = sc.nextLine().split(" ");

        if (strings.length > 0) {
            System.out.print(strings[0]);
        }
        for (int i = 1; i < strings.length; i++) {
            if (strings[i].equals(strings[i-1])) {
                System.out.printf(" %s",strings[i]);
            } else {
                System.out.printf("\n%s",strings[i]);
            }
        }
    }
}
