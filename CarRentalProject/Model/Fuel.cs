using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject.Model;
public sealed class Fuel : VehicleProperty
{
	public Fuel()
	{

	}
	public Fuel(int id, String name)
	{
		Id = id;
		Name = name;
	}
}
