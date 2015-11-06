import java.util.Scanner;

public class _7_CountSubstringOccurencies {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        String words = sc.nextLine().toLowerCase();
        String targetWord = sc.nextLine().toLowerCase();
        int count = 0;
        int index = -1;
        while ((index = words.indexOf(targetWord,index+1))!=-1) {
            count++;
        }
        System.out.println(count);
    }
}
