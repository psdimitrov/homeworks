import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;

/**
 * Created by AAAA on 26.10.2015 ã..
 */
public class _1_SumLines {
    public static void main(String[] args) {
        try (BufferedReader fileReader = new BufferedReader(new FileReader("lines.txt"))) {
            String line = fileReader.readLine();
            while (line!=null) {
                long sum = 0;
                for (int i = 0; i < line.length(); i++) {
                    sum += line.charAt(i);
                }
                System.out.println(sum);
                line = fileReader.readLine();
            }
        }
        catch (IOException ioex) {
            System.err.println("Cannot read the file");
        }
    }
}
