using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalProject.Repository;
using CarRentalProject.Model;
using CarRentalProject.Repository.Dto;
namespace CarRentalProject.Service;
public class VehicleService
{
    VehicleRepository vehicleRepository = new VehicleRepository();
    ValidationService validationService = new ValidationService();
    ColorRepository colorRepository = new ColorRepository();
    FuelRepository fuelRepository = new FuelRepository();
    TransmissionRepository transmissionRepository = new TransmissionRepository();

    public void GetAll()
    {
        List<Vehicle> vehicles = vehicleRepository.GetAll();
        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine(vehicle);
        }
    }

    public void GetById(int id)
    {
        Vehicle vehicle = vehicleRepository.GetById(id);
        Console.WriteLine(vehicle);
    }

    //public void AddVehicle()
    //{
    //    Vehicle createdVehicle = GetVehicleData();
    //    vehicleRepository.AddVehicle(createdVehicle);
    //}
    public void UpdateVehicle()
    {
        Console.WriteLine("Please input the Id of the vehicle to be updated: ");
        string answerToCheck = validationService.CheckAnswer(Console.ReadLine());
        bool isDigit = validationService.CheckNumerical(answerToCheck);
        if (!isDigit)
        {
            Console.WriteLine("You have input an invalid type of data. You must enter a number");
        }
        else
        {
            if (CheckValidId(answerToCheck))
            {
                int id = Convert.ToInt32(answerToCheck);
                Vehicle vehicle = vehicleRepository.GetById(id);
            }
        }


     //   Vehicle updatedVehicle = GetVehicleData();

        //Ask for a vehicle id
        //ask for the updated vehicle
        //get the original vehicle data through GetById
        //Check if any of the permanent values have been updated. If so, give error
        //else, check the values to see if they are valid updates eg.(the updated kilometer Value cannot be lower than present one)
        //if there are problems, give accurate error messages.
        //if there are not any problems, update the vehicle
        
     //   vehicleRepository.UpdateVehicle(updatedVehicle);
      //  Console.WriteLine(updatedVehicle);
    }
    /*
    public Vehicle GetVehicleData()
    {

        int id = vehicleRepository.GetNextId();
        int colorId = GetColor();
        int fuelId = GetFuelType);
        int transmissionId = GetTransmissionType();
        string state = GetVehicleState();
        int kilometers = GetVehicleKilometers();
        short modelYear = GetModelYear();
        string plate = GetPlate();
        string brandName = GetBrandName();
        string modelName = GetModelName();
        double dailyPrice = GetDailyPrice();

        Vehicle createdVehicle = new Vehicle(id, colorId, fuelId, transmissionId, state, kilometers, modelYear, plate, brandName, modelName, dailyPrice);

        return createdVehicle;
    }
    */

    //new Vehicle(1, colorId, FuelID, TransmissionId, "Rented",400000,2017,"34 BKM 2345","Toyota","Corolla",1500),

    public bool CheckValidId(string idToBeChecked)
    {
        List<Vehicle> vehicles = vehicleRepository.GetAll();

        int id = Convert.ToInt32(idToBeChecked);

        if (id <= 0)
        {
            return false;
        }

        foreach (Vehicle vehicle in vehicles) // We check to see if a vehicle with the given Id is already present in the database
        {
            if (vehicle.Id == id)
            {
                return true;
            }
        }

        return false;
    }

    /*
    public Vehicle GetVehicleData()
    {
        int id = GetNextId();
        int fuelId = GetFuel();
        int transmissionId = GetTransmission();
        int colorId = GetColor();
        string carState = GetState();
        int kilometer = GetKilometer();
        short modelYear = GetModelYear();
        string plate = GetPlate();
        string brandName = GetBrand();
        string modelName = GetModel();
        double dailyPrice = GetDailyPrice();


        Vehicle vehicle = new Vehicle(id, colorId, fuelId, transmissionId, carState, kilometer, modelYear, plate, brandName, modelName, dailyPrice);
    }
    */
    
    public void GetAllDetails()
    {
        List<Fuel> fuelList = fuelRepository.GetAll();
        List<Transmission> transmissionList = transmissionRepository.GetAll();
        List<Color> colorList = colorRepository.GetAll();

        List<VehicleDetailDto> vehicles = vehicleRepository.GetAllDetails(colorList, transmissionList, fuelList);

        foreach(VehicleDetailDto vehicleDetail in vehicles)
        {
            Console.WriteLine(vehicleDetail);
        }

    }
    public void GetAllDetailsByFuelId()
    {
        List<Fuel> fuelList = fuelRepository.GetAll();
        List<Transmission> transmissionList = transmissionRepository.GetAll();
        List<Color> colorList = colorRepository.GetAll();
        Fuel fuel = new Fuel(2, "Diesel");
        List<VehicleDetailDto> vehicles = vehicleRepository.GetAllDetailsByFuelId(fuel, colorList, transmissionList);

        foreach (VehicleDetailDto vehicleDetail in vehicles)
        {
            Console.WriteLine(vehicleDetail);
        }
    }

    public void GetAllDetailsByTransmissionId()
    {
        List<Fuel> fuelList = fuelRepository.GetAll();
        List<Transmission> transmissionList = transmissionRepository.GetAll();
        List<Color> colorList = colorRepository.GetAll();
        Transmission transmission = new Transmission(1, "Automatic");
        List<VehicleDetailDto> vehicles = vehicleRepository.GetAllDetailsByTransmissionId(fuelList, colorList, transmission);

        foreach (VehicleDetailDto vehicleDetail in vehicles)
        {
            Console.WriteLine(vehicleDetail);
        }

    }

    public void GetAllDetailsByColorId()
    {
        List<Fuel> fuelList = fuelRepository.GetAll();
        List<Transmission> transmissionList = transmissionRepository.GetAll();
        List<Color> colorList = colorRepository.GetAll();
        Color color = new Color(1, "Black");
        List<VehicleDetailDto> vehicles = vehicleRepository.GetAllDetailsByColorId(color, fuelList, transmissionList );

        foreach (VehicleDetailDto vehicleDetail in vehicles)
        {
            Console.WriteLine(vehicleDetail);
        }

    }

    public void GetAllDetailsByMinMaxPrice()
    {
        List<Fuel> fuelList = fuelRepository.GetAll();
        List<Transmission> transmissionList = transmissionRepository.GetAll();
        List<Color> colorList = colorRepository.GetAll();
        int min = 1000;
        int max = 1400;
        List<VehicleDetailDto> vehicles = vehicleRepository.GetAllDetailsByMinMaxPrice(colorList, fuelList, transmissionList,min, max);

        foreach (VehicleDetailDto vehicleDetail in vehicles)
        {
            Console.WriteLine(vehicleDetail);
        }
    }

    public void GetAllDetailsByBrandNameContains()
    {
        List<Fuel> fuelList = fuelRepository.GetAll();
        List<Transmission> transmissionList = transmissionRepository.GetAll();
        List<Color> colorList = colorRepository.GetAll();
        string brandName = "Audi";

        List<VehicleDetailDto> vehicles = vehicleRepository.GetAllDetailsByBrandNameContains(brandName, colorList, fuelList, transmissionList);

        foreach (VehicleDetailDto vehicleDetail in vehicles)
        {
            Console.WriteLine(vehicleDetail);
        }
    }

    public void GetAllDetailsByModelNameContains()
    {
        List<Fuel> fuelList = fuelRepository.GetAll();
        List<Transmission> transmissionList = transmissionRepository.GetAll();
        List<Color> colorList = colorRepository.GetAll();
        string modelName = "Corolla";

        List<VehicleDetailDto> vehicles = vehicleRepository.GetAllDetailsByModelNameContains(modelName, colorList, fuelList, transmissionList);

        foreach (VehicleDetailDto vehicleDetail in vehicles)
        {
            Console.WriteLine(vehicleDetail);
        }
    }
    public void GetAllDetailsByKilometerRange()
    {
        List<Fuel> fuelList = fuelRepository.GetAll();
        List<Transmission> transmissionList = transmissionRepository.GetAll();
        List<Color> colorList = colorRepository.GetAll();
        int minKilometer = 75000;
        int maxKilometer = 150000;

        List<VehicleDetailDto> vehicles = vehicleRepository.GetAllDetailsByKilometerRange(minKilometer,maxKilometer, colorList, fuelList, transmissionList);

        foreach (VehicleDetailDto vehicleDetail in vehicles)
        {
            Console.WriteLine(vehicleDetail);
        }
    }

}
