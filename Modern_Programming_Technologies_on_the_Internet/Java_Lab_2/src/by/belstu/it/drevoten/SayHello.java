package by.belstu.it.drevoten;

public class SayHello
{
    public boolean isHelloed = false;

    public void setHelloed(boolean helloed) {isHelloed = helloed;}
    public boolean isHelloed()              {return isHelloed;}

    public String getValue()
    {
        if (getString()!=0)
            return "Hello there!";
        return "Hello mr. Zero!";
    }

    private long getString()
    {
        int a32 = 32;
        Integer a16 = 16;
        return a16 + a32;
    }

    public SayHello(){    }

    @Override
    public String toString()
    {
        return "SayHello{" + "isHelloed=" + isHelloed + '}';
    }


}
