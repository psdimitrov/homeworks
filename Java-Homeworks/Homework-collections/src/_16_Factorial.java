import java.math.BigInteger;
import java.util.Scanner;

/**
 * Created by AAAA on 28.10.2015 ã..
 */
public class _16_Factorial {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        System.out.println(factorial(n));
    }
    public static BigInteger factorial(int n) {
        if (n == 1) return new BigInteger("1");
        else {
            return new BigInteger(String.valueOf(n)).multiply(factorial(n-1));
        }
    }
}
