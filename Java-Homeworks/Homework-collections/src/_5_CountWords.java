import java.util.Arrays;
import java.util.Scanner;

public class _5_CountWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] words = sc.nextLine().split("[^A-Za-z]");
        long countEmpty = Arrays.stream(words).filter(a -> a.equals("")).count();
        System.out.println(words.length - countEmpty);
    }
}
