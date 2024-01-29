using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
	internal abstract class Tool : Collectable
	{
		internal Tool(string name) : base(name) {}

		public override void AddMe(List<Collectable> to)
		{
			base.AddMe(to);
			DoAction();
		}

		public abstract void DoAction();
	}
}
