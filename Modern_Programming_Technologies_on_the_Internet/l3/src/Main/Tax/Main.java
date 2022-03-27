package Main.Tax;

import Automobile.Tax.FreightCar;
import Automobile.Tax.LightweightAuto;
import Owner.TaxDeportOwner;
import TaxiDeport.Deport;

import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {
        boolean eightWheels = false;
        boolean sixWheels = true;
        Deport deport = new Deport();
        deport.AddAuto(new LightweightAuto(90, 14000,
                                           "12345qwe67", "1234AA7",
                                           10.0f));
        deport.AddAuto(new LightweightAuto(270, 270000,
                                            "67890rty12", "0001AA1",
                                            60.0f));
        deport.AddAuto(new FreightCar(20, 50500, "8765hea16",
                                      "0978HE9", 88.88f, eightWheels));
        deport.AddAuto(new FreightCar(40, 36000, "35676fgh87",
                                      "4862SA6", 38.5f, sixWheels));

        TaxDeportOwner owner = new TaxDeportOwner();
try {
    System.out.println(owner.CostOfTaxiDeport(deport));           //first owner's ability
    System.err.println("First owner's ability has been used");

    System.out.println(deport.getLaArr());
    System.out.println(deport.getFcArr());
    owner.SortTaxiDeportByConsumption(deport);                    //second owner's ability
    System.err.println("Second owner's ability has been used");
    System.out.println(deport.getLaArr());
    System.out.println(deport.getFcArr());
    if (!deport.getFC(1).equals(new FreightCar(40, 36000, "35676fgh87",
            "4862SA6", 38.5f, sixWheels)))
        throw new IOException("I whant to except!");
    owner.FindTheAutomobileBySpeed(deport, 40, 120);    //third owner's ability
    System.err.println("Third owner's ability has been used");

    System.out.println(deport.getFC(0).hs.Ring());
} catch (IOException e) {
    System.out.println(e.getMessage());
} finally {
    System.out.println("Program finished!");
}
    }
}
