package Automobile.Tax;

public interface IAutomobilible {
    void ExpandMaxSpeed(int speed);
    default int GetMaxSpeed()
    {
        return 60;
    }
    enum WHEELS {
        Three, Four, Five, Six, Eight, Zero;
        public short countOfWheels() {
            switch (this) {
                case Three: return 3;
                case Five: return 5;
                case Six: return 6;
                case Eight: return 8;
                case Zero: return 0;
                case Four:
                default: return 4;
            }
        }
    }
}
