using System.Collections.Generic;

namespace Lab3App
{
	internal abstract class Treasure : Collectable
	{
        internal Treasure(string name, int score) : base(name)
        {
            this.Score = score;
        }

        public int Score { get; set; }

        public override void AddMe(List<Collectable> to)
        {
            base.AddMe(to);
            UpdateTotalScore();
        }

        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
        }
    }
}