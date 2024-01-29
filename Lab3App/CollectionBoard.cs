using System;

namespace Lab3App
{
	internal class CollectionBoard
	{
		private int _totalScore = 0;
		public int TotalScore 
		{
			get => _totalScore;
			set
			{
                _totalScore = value;
                Console.WriteLine("Total Score is updated to: " + _totalScore);
            }
		}
		public int TotalValue { get; set; }
	}
}