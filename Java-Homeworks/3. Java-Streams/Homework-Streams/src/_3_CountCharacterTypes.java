import java.io.*;
import java.util.Arrays;

public class _3_CountCharacterTypes {
    public static void main(String[] args) {
        int vowels = 0;
        int consonants = 0;
        int punctuations = 0;
        int symbol;

        try (FileReader fileReader = new FileReader("words.txt")) {
            while ((symbol = fileReader.read()) != -1) {
                char ch = (char) symbol;
                if (Character.isLetter(ch)) {
                    if (Arrays.asList(new Character[]{'a', 'e', 'i', 'o', 'u'}).contains(ch)) {
                        vowels++;
                    } else {
                        consonants++;
                    }
                } else if (Arrays.asList(new Character[]{'!', ',', '.', '?'}).contains(ch)) {
                    punctuations++;
                }
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
        try (PrintWriter writer = new PrintWriter(new FileWriter("count-chars.txt"))) {
            writer.printf("Vowels: %d%n",vowels);
            writer.printf("Consonants: %d%n",consonants);
            writer.printf("Punctuation: %d%n",punctuations);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
