import java.util.Arrays;
import java.util.Scanner;

public class _6_CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] words = sc.nextLine().toLowerCase().split("[^A-Za-z]");
        String targetWord = sc.nextLine().toLowerCase();
        System.out.println(Arrays.stream(words).filter(a -> a.equals(targetWord)).count());
    }
}
