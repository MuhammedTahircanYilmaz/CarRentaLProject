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

