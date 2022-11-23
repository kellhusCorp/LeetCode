using DesignParkingSystem;

ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
parkingSystem.AddCar(1); // return true because there is 1 available slot for a big car
parkingSystem.AddCar(2); // return true because there is 1 available slot for a medium car
parkingSystem.AddCar(3); // return false because there is no available slot for a small car
parkingSystem.AddCar(1); // return false because there is no available slot for a big car. It is already occupied.