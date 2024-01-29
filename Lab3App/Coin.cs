using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal class Coin : Treasure
	{
		public int Value { get; set; }
		public Coin(string name, int score, int value) : base(name, score)
		{
			Value = value;
		}

		public override void AddMe(List<Collectable> to)
		{
			base.AddMe(to);
			UpdateTotalValue();
		}

		private void UpdateTotalValue()
		{
			Board.TotalValue += Value;
        }
		public override void Display() => Console.WriteLine($"Coin {Description} is displayed");
	}
}