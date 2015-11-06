import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.stream.Stream;

/**
 * Created by AAAA on 28.10.2015 ã..
 */
public class _13_FilterArray {
    public static void main(String[] args) {
        String[] array = new Scanner(System.in).nextLine().split(" ");
        List<String> filtered = Stream.of(array).filter(a -> a.length()>3).collect(Collectors.toList());
        System.out.println(filtered);
    }
}
