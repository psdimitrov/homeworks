import java.io.*;

/**
 * Created by AAAA on 26.10.2015 ã..
 */
public class _2_AllCapitals {
    public static void main(String[] args)  {
        StringBuilder sb = new StringBuilder();
        try (BufferedReader fileReader = new BufferedReader(new FileReader("lines.txt"))) {
            String line;
            while ((line = fileReader.readLine()) != null) {
                sb.append(line.toUpperCase());
                sb.append('\n');
            }

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
        try (PrintWriter writer = new PrintWriter(new FileWriter("lines.txt"))) {
            writer.print(sb.toString());
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
