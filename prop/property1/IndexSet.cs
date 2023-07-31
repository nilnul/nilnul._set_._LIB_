using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.properties
{
	/// <summary>
	/// whose members index another set.
	/// </summary>
	public class IndexSet
		:Set
	{
		public Set set;
		public IndexSet(Set set) {
			this.set = set;
		}
	}
}
