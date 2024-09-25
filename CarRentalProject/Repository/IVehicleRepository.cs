using CarRentalProject.Model;
using CarRentalProject.Repository.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject.Repository
{
    public interface IVehicleRepository
    {
        public List<Vehicle> GetAll();

        public Vehicle AddVehicle(Vehicle vehicle);

        public Vehicle UpdateVehicle(Vehicle vehicle);

        public Vehicle Delete(Vehicle vehicle);

        public Vehicle GetById(int id);

        public int GetNextId();

        public List<string> GetAllVehicleBrands();

        public List<VehicleDetailDto> GetAllDetails(List<Color> colors, List<Transmission> transmissions, List<Fuel> fuels);

        public List<VehicleDetailDto> GetAllDetailsByFuelId(Fuel fuel, List<Color> colors, List<Transmission> transmissions);

        public List<VehicleDetailDto> GetAllDetailsByTransmissionId(List<Fuel> fuelList, List<Color> colors, Transmission transmission);

        public List<VehicleDetailDto> GetAllDetailsByColorId(Color color, List<Fuel> fuelList, List<Transmission> transmissions);

        public List<VehicleDetailDto> GetAllDetailsByMinMaxPrice(List<Color> colors, List<Fuel> fuelList, List<Transmission> transmission, int min, int max);

        public List<VehicleDetailDto> GetAllDetailsByBrandNameContains(string brandName, List<Color> colors, List<Fuel> fuelList, List<Transmission> transmission);

        public List<VehicleDetailDto> GetAllDetailsByModelNameContains(string modelName, List<Color> colors, List<Fuel> fuelList, List<Transmission> transmission);

        public List<VehicleDetailDto> GetAllDetailsByKilometerRange(int min, int max, List<Color> colors, List<Fuel> fuelList, List<Transmission> transmission);

    }
}
