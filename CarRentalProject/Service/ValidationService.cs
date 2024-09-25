using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject.Service;

internal class ValidationService
{
    public bool CheckNumerical(string id)
    {
        string acceptedAnswers = "0123456789";

        foreach (char s in id)
        {
            if (!acceptedAnswers.Contains(s))
            {
                Console.WriteLine("This field has to contain only numbers");
                return false;
            }
        }
        return true;
    }
    
    public bool CheckText(string text)
    {
        string acceptedAnswers = "abcçdefgğhıijklmnoöprsştuüvyzqxw";
        foreach (char s in text)
        {
            if (!acceptedAnswers.Contains(s))
            {
                Console.WriteLine("This field has to contain only text");
                return false;
            }
        }
        return true;
    }

    public string CheckAnswer(string answerToCheck)
    {
        while (string.IsNullOrWhiteSpace(answerToCheck) || string.IsNullOrEmpty(answerToCheck))
        {
            Console.WriteLine("The Answer cannot be Null or Empty. Please input a valid answer:");
            answerToCheck = Console.ReadLine();
        }
        return answerToCheck;
    }
}

