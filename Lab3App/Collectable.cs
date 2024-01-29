using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal abstract class Collectable : Displayable
	{
		public abstract void Display();

		public string Description { get; set; }
		public CollectionBoard Board { get; set; }

		internal Collectable(string name)
		{
			Description = name;
		}

		public virtual void AddMe(List<Collectable> to)
		{
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            to.Add(this);
        }
	}
}