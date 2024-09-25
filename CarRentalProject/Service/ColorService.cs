using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalProject.Model;
using CarRentalProject.Repository;
namespace CarRentalProject.Service;

public class ColorService
{
    ColorRepository colorRepository = new ColorRepository();
    ValidationService validationService = new ValidationService();  
    
    public void GetAll()
    {
        List<Color> colorList = colorRepository.GetAll();
        foreach (Color color in colorList)
        {
            Console.WriteLine(color);
        }
    }

    public void GetById(int id)
    {
        Color color = colorRepository.GetById(id);
        Console.WriteLine(color);
    }

    public void Add()
    {
        Color color = GetColor();
        colorRepository.Add(color);
        Console.WriteLine("Color Added");
        Console.WriteLine(color);
    }
    public void Update(Color color)
    {
        colorRepository.Update(color);
    }
    public void Delete(Color color)
    {
        colorRepository.Delete(color);
    }

    public Color GetColor()
    {
        Color color = new Color();
        color.Name = GetColorName();
        color.Id = GetNextId();
        return color;
    }

    public string GetColorName() 
    {
        Console.WriteLine("Please input The Name of the Color You wish to add: ");
        string answerToCheck = validationService.CheckAnswer(Console.ReadLine());
        bool isText = validationService.CheckText(answerToCheck);
        while(!isText)
        {
            Console.WriteLine("The Color name has to be composed of text");
            Console.WriteLine("Please input a valid Color Name:");
            answerToCheck = validationService.CheckAnswer(Console.ReadLine());
            isText = validationService.CheckText(answerToCheck);
        }
        return answerToCheck;
    }

    public int GetNextId()
    {
        List<Color> colorList = colorRepository.GetAll();
        int id = colorList.OrderBy(x => x.Id).LastOrDefault().Id + 1;
        return id;
    }
}
