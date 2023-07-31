using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.valve
{
	public class Eq<TEl>
		: IEqualityComparer<
			KeyValuePair<
				Var<TEl>, bool
			>
		>
	{
		public bool Equals(KeyValuePair<Var<TEl>, bool> x, KeyValuePair<Var<TEl>, bool> y)
		{
			return x.Key==y.Key && x.Value==y.Value;
		}

		public int GetHashCode(KeyValuePair<Var<TEl>, bool> obj)
		{
			return obj.Key.GetHashCode() & obj.Value.GetHashCode();
		}


		static public Eq<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Eq<TEl>>.Unison;
			}
		}

	}
}
