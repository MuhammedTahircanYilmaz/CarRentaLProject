using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalProject.Model;
using CarRentalProject.Repository.Dto;
//● Bütün Repository classlarda GetById, GetAll,
//Update, Delete, Add metodları olmalıdır

namespace CarRentalProject.Repository;

internal sealed class VehicleRepository : BaseRepository, IVehicleRepository
{
    List<Vehicle> vehicles()
    {
        return Vehicles();
    }
    public List<Vehicle> GetAll()
    {
         return vehicles();
    }

    public Vehicle GetById(int id)
    {
        Vehicle? vehicle = vehicles().FirstOrDefault(v => v.Id == id);
        return vehicle;
    }

    public Vehicle AddVehicle(Vehicle vehicle)
    {
        vehicles().Add(vehicle);
        return vehicle;
    }

    public Vehicle UpdateVehicle(Vehicle updatedVehicle)
    {
        vehicles().Insert(updatedVehicle.Id-1, updatedVehicle);
        return updatedVehicle;
    }

    public Vehicle Delete(Vehicle vehicle)
    {
        vehicles().Remove(vehicle);
        return vehicle;
    }
    public int GetNextId()
    {
        int currentId = Convert.ToInt32(vehicles().OrderBy(x => x.Id).LastOrDefault());
        return currentId + 1;
    }

    
    public List<VehicleDetailDto> GetAllDetails(List<Color> colors, List<Transmission> transmissions, List<Fuel> fuels)
    {
        
   
        var result = from v in vehicles()
                        join c in colors
                        on v.ColorId equals c.Id
                        join t in transmissions
                        on v.TransmissionId equals t.Id
                        join f in fuels
                        on v.FuelId equals f.Id


                        select new VehicleDetailDto(
                        Id : v.Id,
                        FuelName : f.Name,
                        TransmissionType : t.Name,
                        ColorName : c.Name,
                        CarState : v.VehicleState,
                        Kilometer : v.Kilometer,
                        ModelYear : v.ModelYear,
                        Plate : v.Plate,
                        BrandName : v.BrandName,
                        ModelName : v.ModelName,
                        DailyPrice : v.DailyPrice
                        );
      
    return result.ToList();
    }
    

    public List<VehicleDetailDto> GetAllDetailsByFuelId( Fuel fuel, List<Color> colors, List<Transmission> transmissions)
    {
        var result = from v in vehicles()
                     where v.FuelId == fuel.Id
                     join c in colors
                     on v.ColorId equals c.Id
                     join t in transmissions
                     on v.TransmissionId equals t.Id

                     select new VehicleDetailDto(
                         v.Id,
                         fuel.Name,
                         t.Name,
                         c.Name,
                         v.VehicleState,
                         v.Kilometer,
                         v.ModelYear,
                         v.Plate,
                         v.BrandName,
                         v.ModelName,
                         v.DailyPrice
                         );

        return result.ToList();
    }
    public List<VehicleDetailDto> GetAllDetailsByTransmissionId(List<Fuel> fuelList, List<Color> colors, Transmission transmission)
    {
        var result = from v in vehicles()
                     where v.TransmissionId == transmission.Id
                     join c in colors
                     on v.ColorId equals c.Id
                     join f in fuelList
                     on v.FuelId equals f.Id

                     select new VehicleDetailDto(
                         v.Id,
                         f.Name,
                         transmission.Name,
                         c.Name,
                         v.VehicleState,
                         v.Kilometer,
                         v.ModelYear,
                         v.Plate,
                         v.BrandName,
                         v.ModelName,
                         v.DailyPrice
                         );

        return result.ToList();
    }

    public List<VehicleDetailDto> GetAllDetailsByColorId(Color color, List<Fuel> fuelList, List<Transmission> transmissions)
    {
         var result = from v in vehicles()
                     where v.ColorId == color.Id
                     join t in transmissions
                     on v.TransmissionId equals t.Id
                     join f in fuelList
                     on v.FuelId equals f.Id

                     select new VehicleDetailDto(
                         v.Id,
                         f.Name,
                         t.Name,
                         color.Name,
                         v.VehicleState,
                         v.Kilometer,
                         v.ModelYear,
                         v.Plate,
                         v.BrandName,
                         v.ModelName,
                         v.DailyPrice
                         );

        return result.ToList();
    }



    public List<VehicleDetailDto> GetAllDetailsByMinMaxPrice(List<Color> colors, List<Fuel> fuelList, List<Transmission> transmission, int min, int max)
    {
        var result = from v in vehicles()
                     where (v.DailyPrice >= min && v.DailyPrice <= max)
                     join c in colors
                     on v.ColorId equals c.Id
                     join t in transmission
                     on v.TransmissionId equals t.Id
                     join f in fuelList
                     on v.FuelId equals f.Id

                     select new VehicleDetailDto(
                     v.Id,
                     f.Name,
                     t.Name,
                     c.Name,
                     v.VehicleState,
                     v.Kilometer,
                     v.ModelYear,
                     v.Plate,
                     v.BrandName,
                     v.ModelName,
                     v.DailyPrice
                     );
    return result.ToList();
    }

    public List<VehicleDetailDto> GetAllDetailsByBrandNameContains(string brandName, List<Color> colors, List<Fuel> fuelList, List<Transmission> transmission)
    {
        var result = from v in vehicles()
                     where (v.BrandName.Contains(brandName, StringComparison.InvariantCultureIgnoreCase))
                     join c in colors
                     on v.ColorId equals c.Id
                     join t in transmission
                     on v.TransmissionId equals t.Id
                     join f in fuelList
                     on v.FuelId equals f.Id

                     select new VehicleDetailDto(
                     v.Id,
                     f.Name,
                     t.Name,
                     c.Name,
                     v.VehicleState,
                     v.Kilometer,
                     v.ModelYear,
                     v.Plate,
                     v.BrandName,
                     v.ModelName,
                     v.DailyPrice
                     );
        return result.ToList();
    }


    public List<VehicleDetailDto> GetAllDetailsByModelNameContains(string modelName, List<Color> colors, List<Fuel> fuelList, List<Transmission> transmission)
    {
        var result = from v in vehicles()
                    where v.ModelName.Contains(modelName, StringComparison.InvariantCultureIgnoreCase)
                    join c in colors
                    on v.ColorId equals c.Id
                    join t in transmission
                    on v.TransmissionId equals t.Id
                    join f in fuelList
                    on v.FuelId equals f.Id

                    select new VehicleDetailDto(
                    v.Id,
                    f.Name,
                    t.Name,
                    c.Name,
                    v.VehicleState,
                    v.Kilometer,
                    v.ModelYear,
                    v.Plate,
                    v.BrandName,
                    v.ModelName,
                    v.DailyPrice
    );
    return result.ToList();
    }
    public List<VehicleDetailDto> GetAllDetailsByKilometerRange(int min, int max, List<Color> colors, List<Fuel> fuelList, List<Transmission> transmission)
    {
        var result = from v in vehicles()
                     where (v.Kilometer >= min && v.Kilometer <= max)
                     join c in colors
                     on v.ColorId equals c.Id
                     join t in transmission
                     on v.TransmissionId equals t.Id
                     join f in fuelList
                     on v.FuelId equals f.Id

                     select new VehicleDetailDto(
                     v.Id,
                     f.Name,
                     t.Name,
                     c.Name,
                     v.VehicleState,
                     v.Kilometer,
                     v.ModelYear,
                     v.Plate,
                     v.BrandName,
                     v.ModelName,
                     v.DailyPrice
                     );

        return result.ToList();
    }

    public List<string> GetAllVehicleBrands()
    {
        List<string> VehicleBrands = vehicles().Select(x => x.BrandName).ToList();
        return VehicleBrands;
    }
}

