package TaxiDeport;

import Automobile.Tax.FreightCar;
import Automobile.Tax.LightweightAuto;

public interface IDeporterable {
    void AddAuto(LightweightAuto la);
    void AddAuto(FreightCar fc);
    void RemoveAuto(LightweightAuto la);
    void RemoveAuto(FreightCar fc);
}