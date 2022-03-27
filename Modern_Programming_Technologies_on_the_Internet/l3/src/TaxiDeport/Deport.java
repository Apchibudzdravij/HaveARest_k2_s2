package TaxiDeport;

import Automobile.Tax.FreightCar;
import Automobile.Tax.LightweightAuto;

import java.util.*;

public class Deport implements IDeporterable
{
    List<LightweightAuto> laArr;
    List<FreightCar> fcArr;
    int counterLA;
    int counterFC;

    public int getCounterLA() {return counterLA;}
    public void setCounterLA(int counterLA) {this.counterLA = counterLA;}
    public int getCounterFC() {return counterFC;}
    public void setCounterFC(int counterFC) {this.counterFC = counterFC;}

    public List<LightweightAuto> getLaArr() {return laArr;}
    public List<FreightCar> getFcArr() {return fcArr;}

    public LightweightAuto getLA(int i) {return laArr.get(i);}
    public FreightCar getFC(int i) {return fcArr.get(i);}

    public Deport()
    {
        laArr = new ArrayList<>();
        fcArr = new ArrayList<>();
        counterFC = counterLA = 0;
    }

    public void AddAuto(LightweightAuto la)
    {
        counterLA += 1;
        laArr.add(la);
    }
    public void AddAuto(FreightCar fc)
    {
        counterFC += 1;
        fcArr.add(fc);
    }
    public void RemoveAuto(LightweightAuto la)
    {
        for (int i = 0; i < counterLA; ++i)
        {
            if (laArr.get(i).equals(la))
            {
                laArr.remove(i);
                return;
            }
        }
    }
    public void RemoveAuto(FreightCar fc)
    {
        for (int i = 0; i < counterFC; i++)
        {
            if (fcArr.get(i).equals(fc))
            {
                fcArr.remove(i);
                return;
            }
        }
    }

}
