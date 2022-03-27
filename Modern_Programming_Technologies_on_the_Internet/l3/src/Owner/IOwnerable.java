package Owner;

import TaxiDeport.Deport;

public interface IOwnerable {
    default int CostOfTaxiDeport(Deport dp) {return 42000;};
    void SortTaxiDeportByConsumption(Deport dp);
    void FindTheAutomobileBySpeed(Deport dp, int min, int max);
}