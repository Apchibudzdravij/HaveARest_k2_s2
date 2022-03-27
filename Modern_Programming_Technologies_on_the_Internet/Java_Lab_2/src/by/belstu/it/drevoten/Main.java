package by.belstu.it.drevoten;

public class Main
{
    public static void man(String[] args)
    {
        //Hello
        //TODO create Hello method
        //Hello
        SayHello Hello1 = new SayHello();
        Hello1.getValue();

        for (int i=0; i<9; i++)
            if (i > -1 && i < 10)
                System.out.println(i);

        for (int counter = 0; counter < 29648; counter++)
        {
            System.out.println("Counter "+counter);
        }
    }
}
