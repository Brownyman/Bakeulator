using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakeulator.Models
{
	public class IngredientUsed
	{
		public IngredientUsed(Ingredient ingredient, double amountUsed)
		{
			Ingredient = ingredient;
			AmountUsed = amountUsed;
			UsageCost = CalcCost(Ingredient.Cost, Ingredient.Quantity, AmountUsed);
		}

		public Ingredient Ingredient { get; set; }
		public double AmountUsed { get; set; }
		public double UsageCost { get; set; }

		private double CalcCost(double cost, double amount, double used)
		{
			var percentage = (used / amount);
			var result = (cost * percentage);
			return result;
		}
	}
}
