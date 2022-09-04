using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.rel
{
	public partial class EmptyAssert<T>:nilnul.bit.Axiom<IEnumerable<T>>
	{

		static private readonly EmptyAssert<T> _Instance = new EmptyAssert<T>();
		static public EmptyAssert<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		private EmptyAssert()
		
			:base(new Empty<T>())
		{
		}
					
	}
}
