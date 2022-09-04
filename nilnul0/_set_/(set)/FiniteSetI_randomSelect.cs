using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace nilnul.collection.set.finite
{
	static partial class IFiniteSet_Extension
	{
		static public T RandomSelect<T>(this HashSet<T> set) { 
			return set.ElementAt(new Random(DateTime.Now.Millisecond).Next(set.Count));
		}
	}
}
