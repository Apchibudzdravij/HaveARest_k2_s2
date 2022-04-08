package Serial;

import TaxiDeport.Deport;

import java.io.*;

public class Serializator {
    public boolean serialization(Deport card, String fileName) {
        boolean flag = false;
        File f = new File(fileName);
        try (FileOutputStream fos = new FileOutputStream(f)) {
            if (fos != null) {
                ObjectOutputStream ostream =
                        new ObjectOutputStream(fos);
                ostream.writeObject(card); // сериализация
                flag = true;
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
        return flag;
    }

    public Deport deserialization(String fileName)
            throws InvalidObjectException {
        File fr = new File(fileName);
        try ( FileInputStream fis = new FileInputStream(fr)){
            ObjectInputStream istream = new ObjectInputStream(fis);
            Deport dp = (Deport) istream.readObject();
            return dp;
        }
        catch ( IOException | ClassNotFoundException e) {
            e.printStackTrace();
        }
        throw new InvalidObjectException
                ("объект не восстановлен");
    }
}

