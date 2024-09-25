using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalProject.Model;

namespace CarRentalProject.Repository;

public sealed class ColorRepository:BaseRepository
{
    List<Color> colors()
    {
        return Colors();
    }

    public List<Color> GetAll()
    {
        return colors();
    }

    public Color GetById(int id)
    {
        Color color = colors().FirstOrDefault(c=> c.Id == id);
        return color;
    }

    public Color Add(Color color)
    {
        colors().Add(color);
        return color;
    }

    public Color Delete(Color color)
    {
        colors().Remove(color);
        return color;
    }

    public Color Update(Color updatedColor)
    {
        colors().Insert(updatedColor.Id - 1, updatedColor);
        return updatedColor;
    }

}
