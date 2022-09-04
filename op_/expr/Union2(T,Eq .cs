using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.op.expr
{
	public partial class Union2<T,Eq>
		where Eq:IEqualityComparer<T>,new()
	{
		IEnumerable<HashSet<T,Eq>> sets;

		public Union2(IEnumerable<HashSet<T,Eq>> sets)
		{
			this.sets=sets;
		}

		public HashSet<T,Eq> ToLiteral(){
			var r = new HashSet<T,Eq>();
			foreach (var item in sets)
			{
				r.UnionWith(item);
				
			}
			return r;

		}
					
	}
}
