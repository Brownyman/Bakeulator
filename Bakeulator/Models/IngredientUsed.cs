using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakeulator.Models
{
	public class IngredientUsed
	{
		public Ingredient Ingredient { get; set; }
		public double AmountUsed { get; set; }
		public double UsageCost { get; set; }
	}
}
