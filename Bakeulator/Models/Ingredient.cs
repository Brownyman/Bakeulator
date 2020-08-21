using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakeulator.Models
{
	public class Ingredient
	{
		public Ingredient()
		{
		}

		public Ingredient(string name, string unitType, double quantity, double cost)
		{
			Name = name;
			UnitType = unitType;
			Quantity = quantity;
			Cost = cost;
			Editing = false;
		}

		public string Name { get; set; }
		public string UnitType { get; set; }
		public double Quantity { get; set; }
		public double Cost { get; set; }
		public bool Editing { get; set; }
	}
}
