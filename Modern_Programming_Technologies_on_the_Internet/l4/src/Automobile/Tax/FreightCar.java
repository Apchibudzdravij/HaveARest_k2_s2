package Automobile.Tax;

import com.google.gson.annotations.Expose;

import java.io.Serializable;
import java.util.Objects;

public class FreightCar extends Automobile implements IAutomobilible, Serializable {
    @Expose
    int maxSpeed, cost;
    @Expose
    String serialNumber, govNumber;
    @Expose
    float fluelConsumption;
    @Expose
    WHEELS wheels;

    public FreightCar() {
        maxSpeed = 30;
        cost = 2000;
        serialNumber = "";
        govNumber = "";
        fluelConsumption = 10.0f;
        wheels = WHEELS.Six;
    }
    public FreightCar(int mSpeed, int money, String serial, String gov, float consumption, boolean sixWheels) {
        maxSpeed = mSpeed;
        cost = money;
        serialNumber = serial;
        govNumber = gov;
        fluelConsumption = consumption;
        if (sixWheels)
            wheels = WHEELS.Six;
        else
            wheels = WHEELS.Eight;
    }

    public void ExpandMaxSpeed(int speed) {
        if (this.getMaxSpeed()+speed > 60)
            ///add logging
            this.maxSpeed = 60;
        else
            this.maxSpeed += speed;
    }

    public int getMaxSpeed() {
        return maxSpeed;
    }
    public void setMaxSpeed(int maxSpeed) {
        ///add logging here! (if maxSpeed>60 => log "max speed has been set at 60, because it can't be higher!")
        if (maxSpeed <= 60)
            this.maxSpeed = maxSpeed;
        else
            this.maxSpeed = 60;
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

    public int getCost() {
        return cost;
    }
    public void setCost(int cost) {
        this.cost = cost;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        FreightCar that = (FreightCar) o;
        return Objects.equals(serialNumber, that.serialNumber) && Objects.equals(govNumber, that.govNumber) && wheels == that.wheels;
    }

    @Override
    public String toString() {
        return "\nThis freight car has" +
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
    public class HeavySound implements Serializable {
        public String Ring() {
            return "Vroooom!";
        }
    }
    public HeavySound hs = new HeavySound();
}
