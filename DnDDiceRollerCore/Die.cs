using System;

namespace DnDDiceRollerCore
{
	public class Die
	{
		public string name { get; set; }
		public int min { get; set; }
		public int max { get; set; }

		public Die(string name, int min, int max)
		{
			this.name = name;
			this.min = min;
			this.max = max;
		}

		public int roll()
		{
			Random r = new Random();
			Console.Write(r.Next(this.min, this.max));
			return r.Next(this.min, this.max);
		}
	}
}

