using CarRentalProject.Model;
using CarRentalProject.Service;

VehicleService vehicleService = new VehicleService();

//new Vehicle(2, 1, 1, 2, "Available", 150000, 2020, "34 BED 256", "Honda", "Civic", 1400);

Vehicle vehicle = new Vehicle(2, 3, 1, 2, "Rented", 100000, 2000, "34 BED 256", "Honda", "Civic", 1000);

vehicleService.GetAllDetailsByKilometerRange();