﻿using System;

namespace Lab3App
{
	internal class MagicWand : Tool
	{
		public MagicWand(string name) : base(name) {}

        public override void Display() => Console.WriteLine($"MagicWand {Description} is displayed");
        public override void DoAction() => Console.WriteLine("MagicWand is Used");
    }
}