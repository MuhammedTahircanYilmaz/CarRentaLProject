
using CarRentalProject.Model;

namespace CarRentalProject.Repository;

public abstract class BaseRepository
{
    private List<Vehicle> vehicles = new List<Vehicle>()
    {
        new Vehicle(1, 1, 1, 2, "Rented",400000,2017,"34 BKM 2345","Toyota","Corolla",1500),
        new Vehicle(2, 1, 1, 2, "Available",150000,2020,"34 BED 256","Honda","Civic",1400),
        new Vehicle(3, 2, 1, 1, "Available",240000,2017,"34 OSC 1423","Ford","Focus",1000),
        new Vehicle(4, 4, 1, 1, "Rented",102000,2023,"34 KIL 8650","Fiat","Doblo",1300),
        new Vehicle(5, 3, 2, 2, "Rented",60000,2024,"34 YUR 907","BMW","M8",2300),
        new Vehicle(6, 3, 2, 2, "Available",170000,2022,"34 NT 5644","Audi","A5",2000)
    };

    List<Color> colors = new List<Color>()
    {
        new Color(1,"Black"),
        new Color(2,"White"),
        new Color(3,"Gray"),
        new Color(4,"Blue"),
        new Color(5,"Red"),
        new Color(6,"Green"),
    };

    List<Fuel> fuelList = new List<Fuel>()
    {
        new Fuel(1,"Benzine"),
        new Fuel(2,"Diesel"),
        new Fuel(3,"LPG"),
        new Fuel(4,"Jet Fuel"),
    };

    List<Transmission> transmissions = new List<Transmission>()
    {
        new Transmission(1, "Automatic"),
        new Transmission(2, "Manual")
    };

    public List<Vehicle> Vehicles()
    {
        return vehicles;
    }
    public List<Fuel> FuelList()
    {
        return fuelList;
    }

    public List<Transmission> Transmissions()
    {
        return transmissions;
    }

    public List<Color> Colors()
    {
        return colors;
    }

}

