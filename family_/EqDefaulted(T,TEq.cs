using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.set.family_
{
	public class EqDefaulted<T, TEq> :

		nilnul.set.Family<T>


		where TEq : IEqualityComparer<T>, new()

	{
		public EqDefaulted(IEqualityComparer<T> objEq) : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		public EqDefaulted( IEnumerable<HashSet<T>> sets) : base(nilnul.obj_.Singleton<TEq>.Instance, sets)
		{
		}
	}
}
