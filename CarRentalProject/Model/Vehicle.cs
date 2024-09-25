using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject.Model;

public class Vehicle
{
    private int _id;
    private int _colorId;
    private int _fuelId;
    private int _transmissionId;
    private string _vehicleState;
    private int? _kilometer;
    private short? _modelYear;
    private string? _plate;
    private string? _brandName;
    private string? _modelName;
    private double? _dailyPrice;

    public Vehicle() 
    { 
    }

    public Vehicle(
        int id,
        int colorId,
        int fuelId,
        int transmissionId,
        string carState,
        int? kilometer,
        short? modelYear,
        string? plate,
        string? brandName,
        string? modelName,
        double? dailyPrice)
    {
        Id = id;
        ColorId = colorId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        VehicleState = carState;
        Kilometer = kilometer;
        ModelYear = modelYear;
        Plate = plate;
        BrandName = brandName;
        ModelName = modelName;
        DailyPrice = dailyPrice;
    }

    public int Id
    {
        get
        {
            return _id;
        }

        init 
        {
            _id = value;
        }
    }
    public int ColorId 
    {
        get
        {
            return _colorId;
        } 
        
        set 
        {
            _colorId = value;
        }
    }
    public int FuelId 
    {
        get 
        {
            return _fuelId;
        }
        
        init 
        { 
            _fuelId = value;
        }
    }
    public int TransmissionId 
    {
        get 
        {
            return _transmissionId;
        }

        init
        { 
            _transmissionId = value;
        }
    }
    public string VehicleState 
    {
        get 
        {
            return _vehicleState;
        } 
        set
        {
            _vehicleState = value;
        }
    }
    public int? Kilometer 
    { 
        get 
        {
            return _kilometer;    
        }
        
        set
        {
            _kilometer = value;
        }
    }
    public short? ModelYear
    {
        get
        {
            return _modelYear;
        }

        init
        {
            _modelYear = value;
        }
    }
    public string? Plate 
    {
        get
        {
            return _plate;
        }
        init
        {
            _plate = value;
        }
    }

    public string? BrandName 
    {
        get 
        {
            return _brandName;
        }
        init
        {
            _brandName = value;
        }
    }
    public string? ModelName {
        get
        {
            return _modelName;
        } 
        
        init 
        {
            _modelName = value;
        }
    }
    public double? DailyPrice 
    {
        get
        {
            return _dailyPrice;
        }
        
        set 
        {
            _dailyPrice = value;
        }
    }
    public override string ToString()
    {
        return $"{{Vehicle:\nId: {Id}\nColor Id: {ColorId}\nFuel Id: {FuelId}\nTransmission Id: {TransmissionId}\nCar State: {VehicleState}" +
            $"\nKilometer: {Kilometer}\nModel Year: {ModelYear}\nPlate: {Plate}\nBrand Name: {BrandName}\nModel Name: {ModelName}\nDaily Price: {DailyPrice}}}\n";
    }
}
