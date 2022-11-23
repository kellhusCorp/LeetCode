namespace DesignParkingSystem;

public class ParkingSystem {

    private int bigCapacity;
    
    private int mediumCapacity;
    
    private int smallCapacity;
    
    private int bigCount;
    
    private int mediumCount;
    
    private int smallCount;
    
    public ParkingSystem(int big, int medium, int small) 
    {
        bigCapacity = big;
        mediumCapacity = medium;
        smallCapacity = small;
    }
    
    public bool AddCar(int carType)
    {
        if (carType == 3 && smallCount + 1 <= smallCapacity)
        {
            smallCount++;
            return true;
        }

        if (carType == 1 && bigCount + 1 <= bigCapacity)
        {
            bigCount++;
            return true;
        }
        if (carType == 2 && mediumCount + 1 <= mediumCapacity)
        {
            mediumCount++;
            return true;      
        }

        return false;
    }
}