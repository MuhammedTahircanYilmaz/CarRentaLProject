using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalProject.Model;

namespace CarRentalProject.Repository;
public sealed class TransmissionRepository : BaseRepository
{
    List<Transmission> transmissions()
    {
        return Transmissions();
    }

    public List<Transmission> GetAll()
    {
        return transmissions();
    }

    public Transmission GetById(int Id)
    {
        Transmission transmission = transmissions().FirstOrDefault(x => x.Id == Id);
        return transmission;
    }

    public Transmission Add(Transmission transmission)
    {
        transmissions().Add(transmission);
        return transmission;
    }

    public Transmission Update(Transmission transmission)
    {
        transmissions().Insert(transmission.Id -1, transmission);
        return transmission;
    }

    public Transmission Delete(Transmission transmission)
    {
        transmissions().Remove(transmission);
        return transmission;
    } 


}
