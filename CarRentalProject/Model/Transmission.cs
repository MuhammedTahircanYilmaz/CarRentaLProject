using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject.Model;
public sealed class Transmission : VehicleProperty
{
	public Transmission()
	{

	}
	public Transmission(int id, string name)
	{
		Id = id;
		Name = name;
	}
}
