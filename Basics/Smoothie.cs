using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

	public class Smoothie {

		static Dictionary<string, double> prices = new Dictionary<string, double>()
		{
			{ "Strawberries", 1.50 },
			{ "Banana", 0.50 },
			{ "Mango", 2.50 },
			{ "Blueberries", 1.00 },
			{ "Raspberries", 1.00 },
			{ "Apple", 1.75 },
			{ "Pineapple", 3.50 }
		};
		
		public string[] Ingredients { get; set; }
		private double cost;
		
		public Smoothie(string[] ingredients) {
			Ingredients = ingredients;
		}
		
		public string GetCost() {
			for(int i = 0; i < Ingredients.Length; i++) {
				var ingredientPrice = Math.Round(prices.FirstOrDefault(x => x.Key == Ingredients[i]).Value, 2);
				cost += ingredientPrice;
			}
			
			return "£" + cost.ToString("0.00");
		}		

		public string GetPrice() {
			cost = cost + cost * 1.50;
			return "£" + cost.ToString("0.00");
		}

		public string GetName() {
			string [] sortedArray = Ingredients.OrderBy(ingredient => ingredient).ToArray();
			string name = "";
			for(int i = 0; i < sortedArray.Length; i++) {
				string fruit = sortedArray[i].Replace("berries", "berry");
				name += fruit + " ";
			}

			if(sortedArray.Length > 1) {
				name += "Fusion";
			} else {
				name += "Smoothie";
			}
			return name;
		}
	}	
