using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;

namespace nilnul.element.collection.set
{
	public abstract partial class SetOpA
	{

		public abstract  char sign
		{
			get;
		}

		public override string ToString()
		{
			return sign.ToString();
		}
	}
}
