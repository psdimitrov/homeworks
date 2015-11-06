import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

/**
 * Created by AAAA on 28.10.2015 ã..
 */
public class _14_SortArrayStream {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<String> arr = new ArrayList<>();
        arr.addAll(Arrays.asList(sc.nextLine().split(" ")));
        String sortType = sc.nextLine();

        if(sortType.equals("Ascending")) {
            arr.stream()
                    .map(s -> Integer.parseInt(s))
                    .sorted((num1, num2) -> num1.compareTo(num2))
                    .forEach(num -> System.out.print(num + " "));
        } else {
            arr.stream()
                    .map(s -> Integer.parseInt(s))
                    .sorted((num1, num2) -> num2.compareTo(num1))
                    .forEach(num -> System.out.print(num + " "));
        }
    }
}
