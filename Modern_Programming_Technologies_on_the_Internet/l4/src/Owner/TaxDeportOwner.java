package Owner;

import Automobile.Tax.FreightCar;
import Automobile.Tax.LightweightAuto;
import TaxiDeport.Deport;

import java.util.Comparator;

public class TaxDeportOwner implements IOwnerable
{
    public int CostOfTaxiDeport(Deport dp) {
        int totalCost = 0;
        for (int i=0; i < dp.getCounterLA(); ++i)
        {
            totalCost += dp.getLA(i).getCost();
        }
        for (int i=0; i < dp.getCounterFC(); ++i)
        {
            totalCost += dp.getFC(i).getCost();
        }
        return totalCost;
    }
    public void SortTaxiDeportByConsumption(Deport dp) {
        dp.getFcArr().sort(Comparator.comparing(FreightCar::getFluelConsumption));
        dp.getLaArr().sort(Comparator.comparing(LightweightAuto::getFluelConsumption));
    }
    public void FindTheAutomobileBySpeed(Deport dp, int min, int max) {
        for (int i = 0; i < dp.getCounterLA(); i++)
        {
            if ((dp.getLA(i).getMaxSpeed() >= min )&&(dp.getLA(i).getMaxSpeed() <= max))
            {
                System.out.println(dp.getLA(i).toString());
            }
        }
        for (int i = 0; i < dp.getCounterFC(); i++)
        {
            if ((dp.getFC(i).getMaxSpeed() >= min )&&(dp.getFC(i).getMaxSpeed() <= max))
            {
                System.out.println(dp.getFC(i).toString());
            }
        }
    }
}
