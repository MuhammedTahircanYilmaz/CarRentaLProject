using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject.Repository;

internal class IFuelData
{
    using CarRentalProject.Model;
namespace CarRentalProject.Repository;

public interface IColorRepository
{
    public List<Color> GetAll();

    public Color GetById(int id);

    public Color Add(Color color);

    public Color Delete(Color color);

    public Color Update(Color updatedColor);

}
}

