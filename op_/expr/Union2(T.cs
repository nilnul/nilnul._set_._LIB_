using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.op.expr
{
	public partial class Union2<T>
	{
		IEnumerable<HashSet<T>> sets;

		public Union2(IEnumerable<HashSet<T>> sets)
		{
			this.sets=sets;
		}

		public HashSet<T> toLiteral(){
			var r = new HashSet<T>();
			foreach (var item in sets)
			{
				r.UnionWith(item);
				
			}
			return r;

		}
					
	}
}
