using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.op.expr
{
	public partial class Union3<T,Eq>
		where Eq:IEqualityComparer<T>,new()
	{
		IEnumerable<Set<T,Eq>> sets;

		public Union3(IEnumerable<Set<T,Eq>> sets)
		{
			this.sets=sets;
		}

		public Set<T,Eq> ToLiteral(){
			var r = new Set<T,Eq>();
			foreach (var item in sets)
			{
				r.UnionWith(item);
				
			}
			return r;

		}
					
	}
}
