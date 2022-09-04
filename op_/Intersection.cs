using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.operation
{
	public class Intersection
	{
		public Set[] sets;
		public Intersection(Set[] sets) {
			this.sets = sets;
		}
		public override string ToString()
		{
			return "*("+ sets.ToStr_flat()+")";
		}
	}
}
