using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.duo.op
{
	public partial class Union<T,TEq>
		:nilnul.duo.OpI<Set_eqDefault<T,TEq>>
		where TEq:IEqualityComparer<T>,new()
		
	{

		static public readonly Union<T, TEq> Singleton = SingletonByDefault<Union<T, TEq>>.Instance;


		public Set_eqDefault<T, TEq> eval(Set_eqDefault<T, TEq> a, Set_eqDefault<T, TEq> b)
		{
			var r = new Set_eqDefault<T, TEq>(a);
			r.UnionWith(b);

			return r;

			throw new NotImplementedException();
		}
	}
}
