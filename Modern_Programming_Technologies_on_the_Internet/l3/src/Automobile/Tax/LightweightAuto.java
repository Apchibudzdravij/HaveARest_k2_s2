package Automobile.Tax;

import java.util.Objects;

public class LightweightAuto extends Automobile implements IAutomobilible {
    int maxSpeed, cost;
    String serialNumber, govNumber;
    float fluelConsumption;
    WHEELS wheels = WHEELS.Four;

    public int getMaxSpeed() {
        return maxSpeed;
    }
    public void setMaxSpeed(int maxSpeed) {
        this.maxSpeed = maxSpeed;
    }

    public int getCost() {
        return cost;
    }
    public void setCost(int cost) {
        this.cost = cost;
    }

    public String getSerialNumber() {
        return serialNumber;
    }
    public void setSerialNumber(String serialNumber) {
        this.serialNumber = serialNumber;
    }

    public String getGovNumber() {
        return govNumber;
    }
    public void setGovNumber(String govNumber) {
        this.govNumber = govNumber;
    }

    public float getFluelConsumption() {
        return fluelConsumption;
    }
    public void setFluelConsumption(float fluelConsumption) {
        this.fluelConsumption = fluelConsumption;
    }

    public LightweightAuto(int speed, int money, String serial, String gov, float consumption) {
        this.setMaxSpeed(speed);
        this.setCost(money);
        this.setSerialNumber(serial);
        this.setGovNumber(gov);
        this.setFluelConsumption(consumption);
    }

    public void ExpandMaxSpeed(int speed) {
        this.maxSpeed += speed;
    };
    public int GetMaxSpeed() {
        return this.getMaxSpeed();
    };

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        LightweightAuto that = (LightweightAuto) o;
        return serialNumber.equals(that.serialNumber) && govNumber.equals(that.govNumber) && wheels == that.wheels;
    }

    @Override
    public String toString() {
        return "\nThis lightweight car has" +
                wheels + " wheels, " +
                maxSpeed + " as maximal speed, " +
                "fluel consumption is " + fluelConsumption +
                ".\nIt costs " + cost +
                ", serial number is " + serialNumber + " and " +
                " government number is " + govNumber + ".\n";
    }
    /*@Override
    public int hashCode() {
        return Objects.hash(serialNumber, govNumber, wheels);
    }*/
}
