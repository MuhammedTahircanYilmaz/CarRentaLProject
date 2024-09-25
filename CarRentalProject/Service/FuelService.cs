using CarRentalProject.Model;
using CarRentalProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject.Service;

public class FuelService
{
    FuelRepository fuelRepository = new FuelRepository();
    ValidationService validationService = new ValidationService();

    public void GetALl()
    {
        fuelRepository.GetAll();
    }
    public void GetById(int id)
    {
        fuelRepository.GetById(id);
    }

    public void Add()
    {
        Fuel fuel = GetFuel();
        fuelRepository.Add(fuel);
        Console.WriteLine("Fuel Added");
        Console.WriteLine(fuel);

    }
    public void Update()
    {
        Fuel fuel = GetFuel();
        fuelRepository.Update(fuel);
    }

    public void Delete(Fuel fuel)
    {
        fuelRepository.Delete(fuel);
    }

    public Fuel GetFuel()
    {
        Fuel fuel = new Fuel();
        fuel.Name = GetFuelType();
        fuel.Id = GetNextId();
        return fuel;
    }

    public string GetFuelType()
    {
        Console.WriteLine("Please input The Type of the Fuel You wish to add: ");
        string answerToCheck = validationService.CheckAnswer(Console.ReadLine());
        bool isText = validationService.CheckText(answerToCheck);
        while (!isText)
        {
            Console.WriteLine("The Fuel Type has to be composed of text");
            Console.WriteLine("Please input a valid Fuel Type:");
            answerToCheck = validationService.CheckAnswer(Console.ReadLine());
            isText = validationService.CheckText(answerToCheck);
        }
        return answerToCheck;
    }

    public int GetNextId()
    {
        List<Fuel> fuelList = new List<Fuel>();
        int nextId = fuelList.OrderBy(x => x.Id).LastOrDefault().Id+1;
        return nextId;
    }
}

