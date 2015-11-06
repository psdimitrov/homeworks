import java.io.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

/**
 * Created by AAAA on 26.10.2015 ã..
 */
public class SaveArrayListDoubles {
    public static void main(String[] args) {
        List<Double> list = new ArrayList<Double>() {{
            addAll(Arrays.asList(4.5, 23.5, 12.4, 3.4, 1.67, 8.45));
        }};
        SaveArray(list);
        LoadArray();
    }

    private static void SaveArray(List<Double> list) {
        try(ObjectOutputStream writer = new ObjectOutputStream(new FileOutputStream("doubles.list"))) {
            writer.writeObject(list);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    private static void LoadArray() {
        try(ObjectInputStream reader = new ObjectInputStream(new FileInputStream("doubles.list"))) {
            System.out.println(reader.readObject());
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }
    }
}

