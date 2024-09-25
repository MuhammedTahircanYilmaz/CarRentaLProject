using CarRentalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject.Repository;
internal sealed class FuelRepository : BaseRepository
{
    List<Fuel> fuelList()
    {
        return FuelList();
    }

    public List<Fuel> GetAll()
    {
        return fuelList();
    }

    public Fuel GetById(int id)
    {
        Fuel fuel = fuelList().FirstOrDefault(x => x.Id == id);
        return fuel;
    }

    public Fuel Add(Fuel fuel)
    {
        fuelList().Add(fuel);
        return fuel;
    }

    public Fuel Update(Fuel updatedFuel) 
    {
        fuelList().Insert(updatedFuel.Id-1, updatedFuel);
        return updatedFuel;
    }

    public Fuel Delete(Fuel fuel)
    {
        fuelList().Remove(fuel);
        return fuel;
    }
}
