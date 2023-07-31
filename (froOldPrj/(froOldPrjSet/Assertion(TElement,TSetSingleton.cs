using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set
{
	public partial class Assertion<TElement,TSetSingleton>
		:Assertion<TElement>
		where TSetSingleton:SetI<TElement>,new()
		
	{

		public Assertion()
			:base(SingletonByDefaultNew<TSetSingleton>.Instance)
		{
		}
	
					

	}
}
