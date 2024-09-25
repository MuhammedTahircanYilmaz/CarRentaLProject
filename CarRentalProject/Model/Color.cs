using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject.Model;
public sealed class Color : VehicleProperty
{
	public Color()
	{

	}
	public Color(int id, string name)
	{
		Id = id;
		Name = name;
	}
}


