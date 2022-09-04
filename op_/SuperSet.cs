using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.element.collection.set.relation
{
	public partial class SuperSet
		:ISuperSet
	{

		static private readonly SuperSet _Instance = new SuperSet();
		static public SuperSet Instance
		{
			get
			{
				return _Instance;
			}
		}
		private SuperSet()
		{
		}
				
	}
}
