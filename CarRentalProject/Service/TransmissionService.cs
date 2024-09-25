using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalProject.Model;
using CarRentalProject.Repository;


namespace CarRentalProject.Service;
public class TransmissionService
{
    TransmissionRepository transmissionRepository = new TransmissionRepository();
    ValidationService validationService = new ValidationService();

    public void GetAll()
    {
        List<Transmission> transmissionTypes = transmissionRepository.GetAll();
        transmissionTypes.ForEach(t => Console.WriteLine(t));
    }

    public void GetById(int id)
    {
        Transmission transmission = transmissionRepository.GetById(id);
        Console.WriteLine(transmission);
    }

    public void Add()
    {
        Transmission transmission = GetTransmission();
        transmissionRepository.Add(transmission);
        Console.WriteLine("Transmission Added");
        Console.WriteLine(transmission);
    }

    public void update(Transmission transmission)
    {
        transmissionRepository.Update(transmission);
    }

    public void Delete(Transmission  transmission)
    {
        transmissionRepository.Delete(transmission);
    }

    public Transmission GetTransmission()
    {
        Transmission transmission = new Transmission();
        transmission.Name = GetTransmissionType();
        transmission.Id = GetNextId();
        return transmission;
    }
    public string GetTransmissionType()
    {
        Console.WriteLine("Please input The Type of the Transmission You wish to add: ");
        string answerToCheck = validationService.CheckAnswer(Console.ReadLine());
        bool isText = validationService.CheckText(answerToCheck);
        while (!isText)
        {
            Console.WriteLine("The Transmission type has to be composed of text");
            Console.WriteLine("Please input a valid Transmission type:");
            answerToCheck = validationService.CheckAnswer(Console.ReadLine());
            isText = validationService.CheckText(answerToCheck);
        }
        return answerToCheck;
    }

    public int GetNextId()
    {
        List<Transmission> transmissions = transmissionRepository.GetAll();
        int id = transmissions.OrderBy(x => x.Id).LastOrDefault().Id + 1;
        return id;
    }
}
