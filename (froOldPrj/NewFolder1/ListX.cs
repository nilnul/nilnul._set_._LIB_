using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set
{
	static public partial class ListX
	{
		static public bool Equals<T>(List<T> x,List<T> y) {

			if (x==null && y==null )
			{
				return true;
				
			}
			if (x==null || y==null)
			{
				return false;
				
			}

			if (x.Count!=y.Count)
			{
				return false;
				
			}

			for (int i = 0; i < x.Count; i++)
			{
				if (!object.Equals( x[i],y[i]))
				{
					return false;
					
				}
				
			}
			return true;
		
		}
	}
}
