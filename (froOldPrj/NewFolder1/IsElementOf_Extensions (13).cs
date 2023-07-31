using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set
{
	static public class IsMemberOf_Extensions
	{
		static public bool IsMemberOf<T>(this T element, TypeInstancesSet set) {
			return set.hasElement(element);
		}
	}
}
