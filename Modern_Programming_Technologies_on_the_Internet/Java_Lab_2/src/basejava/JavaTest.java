package basejava;
import java.nio.charset.StandardCharsets;
import java.util.Random;

import static java.lang.Math.*;
import java.util.Arrays;

public class JavaTest
{//Задание a
    static int sint;

    /**
     * @return void
     * @throws -
     * @param args
     */
    public static void main(String[] args)
    {
        //Задание b
            char ch1 = 'c';
            int int1 = 1;
            short sh1 = 128;
            byte bt1 = (byte) 12000;
            long lg1 = 12000;
            boolean bl1 = true;
            String str1 = new String("I");
        {//Задание b, но операции
                System.out.println("String + int: " + str1+int1);
                System.out.println("String + char: " + str1+ch1);
            double db1=12.56;
                System.out.println("String + double: " + str1+db1);
            byte bt2 = (byte)(bt1 + int1);
                System.out.println("byte = byte + int: " + bt2);
            int int2 = (int)(db1 + lg1);
                System.out.println("int = double + long: " + int2);
            long lg2 = int1 + (long)2147483647;
                System.out.println("long = int + 2147483647: " + lg2);
                System.out.println("static int sint: " + sint);
            boolean bl2 = false;
            boolean bl1and2 = bl1&&bl2;
                System.out.println("&&: " + bl1and2);
            boolean bl1xor2 = bl1^bl2;
                System.out.println("^: " + bl1xor2);
            //boolean blsumm = bl1+bl2;
            long intlong = 9223372036854775807L;
                System.out.println("9223372036854775807: " + intlong);
            long hexintlong = 0x7ffffffffffL;
            System.out.println("0x7ffffffffff: " + hexintlong);
            char a = 'a'; char u0061 = '\u0061'; char _97 = 97;
                System.out.println(a+" "+u0061+" "+_97);
            char summirize = (char)(a + u0061 + _97);
                System.out.println("Summ of symbols: " + summirize);
            System.out.println("3.45%2.4: " + (3.45%2.4));
            System.out.println("1.0/0.0: " + (1.0/0.0));
            System.out.println("0.0/0.0: " + (0.0/0.0));
            System.out.println("log(-345): " + (Math.log(-345)));
            System.out.println("Float.intBitsToFloat(0x7F800000): " + Float.intBitsToFloat(0x7F800000));
        }
        {//Задание c
            final int miau1 = 1;
            //public final int miau2 = 2;
            //public static final int miau3 = 3;
        }
        {//задание d
            System.out.println("Pi: "+ PI);
            System.out.println("E: "+ E);
            System.out.println("Pi(rounded): "+ Math.round(PI));
            System.out.println("E(rounded): "+ Math.round(E));
            System.out.println("min(Pi,E): "+ Math.min(PI,E));
            System.out.println("Random[0,1)="+ (new Random()).nextFloat());
        }
        //задание e
        Boolean bool1 = false;
        Character char1 = 'G';
        Integer integer1 = -12345;
        Byte byte1 = Byte.MAX_VALUE;
        Short short1 = 3210;
        Long long1 = Long.MIN_VALUE;
        Double double1 = Double.MIN_VALUE;
        {//задание е, но операции
            System.out.println("Integer: " + integer1 + "\nInteger>>>2: " + (integer1 >>> 2) + "\nInteger>>2: " + (integer1 >> 2));
            System.out.println("~Integer: " + ~integer1 + "\nInteger&Short: "  + (integer1&short1) + "\nLong*Double: " + (long1*double1));
            System.out.println("Character+Boolean: "+ (char1+Boolean.toString(bool1)) +"\nInteger-Double: " + (integer1-double1));

            System.out.println("Long min: "+Long.MIN_VALUE+"Long max: "+Long.MAX_VALUE+"Double min: "+Double.MIN_VALUE+"Double max: "+Double.MAX_VALUE);

            Integer intBox = int1;
            int intUnbox = intBox;
            Byte byteBox = bt1;
            byte byteUnbox = byteBox;

            System.out.println(Integer.parseInt("23"));
            System.out.println(Integer.toHexString(23));
            System.out.println(Integer.compare(2,3));
            System.out.println(Integer.toString(23));
            System.out.println(Integer.bitCount(23));
        }
        {//задание f
            String s34 = "2345";
            int i1_s34 = new Integer(s34);
            int i2_s34 = Integer.valueOf(s34);
            int i3_s34 = Integer.parseInt(s34);
            System.out.println(i1_s34 + " " + i2_s34 + " " + i3_s34);
            {
                byte[] byteArr_s34 = s34.getBytes(StandardCharsets.UTF_8);
                System.out.println("String to byte array: " + Arrays.toString(byteArr_s34));
                String newStrFromByteArr = new String(byteArr_s34);
                System.out.println("String from byte array: " + newStrFromByteArr);
                boolean bool1_s34 = new Boolean(s34);
                boolean bool2_s34 = Boolean.getBoolean(s34);
                System.out.println(bool1_s34 + " " + bool2_s34);
                String s35_1 = new String("8965");
                String s35_2 = new String("8965");
                System.out.println(s35_1 == s35_2);
                System.out.println(s35_1.compareTo(s35_2));
                System.out.println(s35_1.equals(s35_2));
                System.out.println(s34.hashCode());
                CharSequence c4 = new StringBuffer(4);
                System.out.println(s34.contains(c4));
                System.out.println(s34.replace('4', '9'));
                System.out.println(s34.indexOf('2'));
                System.out.println(s34.length());
                String[] splited_s34 = s34.split("4");
                System.out.println(splited_s34[0] + " & " + splited_s34[1] + " : "
                        + splited_s34.length);
            }
        }
        {//задание g
            Character[][] c0 = new Character[0][0];
            char[][] c1;
            char[] c2[];
            char c3[][];
            //System.out.println(c0[1][1]);//java.lang.ArrayIndexOutOfBoundsException
            c1 = new char[3][];
            int c1minimal = 4;
            for (int i = 0; i < 3; i++)
            {
                c1[i] = new char[c1minimal + i];
            }
            for (int i = 0; i < 3; i++)
            {
                System.out.println(c1[i]);
            }
            System.out.println(c1.length + " -> " + c1[0].length +
                       " & " + c1[1].length + " & " + c1[2].length);
            c2 = new char[2][2];
            c2[0][0] = 'n'; c2[0][1] = 'e';
            c2[1][0] = 'w'; c2[1][1] = 'c';
            c3 = new char[1][1];
            c3[0][0] = 'h';
            boolean comRez = c3==c2;
            System.out.println(comRez);
            for (char x: c2[1])
            {
                System.out.print(x + " ");
            }
            c2=c3;
            //System.out.println(c2[0][1]);
        }
        {//задание h
            /**
             * @value Heeeo
             * @see JavaTest#main(String[]) 
             */
            WrapperString ws = new WrapperString("Hello");
            ws.replace('l', 'e');
            /**
             * Вывод изменённой строки
             * @param ws
             */
            System.out.println("\n" + ws);

            WrapperString wrappedStr = new WrapperString()
            {
                @Override
                public void replace(char oldchar, char newchar)
                {
                    super.replace(oldchar, 'S');
                }

                public void delete(char delchar)
                {
                    super.replace(delchar, "".toCharArray()[0]);
                }
            };
            wrappedStr.setWrap("qer");
            wrappedStr.replace('e', 'r');
            System.out.println(wrappedStr);
        }
        /**
         * вот тут программа и закончится, примерно.
         */
    }
}
