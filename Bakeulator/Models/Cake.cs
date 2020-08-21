using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakeulator.Models
{
	public class Cake
	{
		public string Name { get; set; }
		public double LabourCost { get; set; }
		public double TotalCost { get; set; }
		public IEnumerable<IngredientUsed> Ingredients { get; set; }
	}
}
