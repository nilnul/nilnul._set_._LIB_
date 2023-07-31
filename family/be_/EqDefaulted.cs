using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.be_
{
	public abstract class OfEqDefaultedA<T, TEq>
		:
		nilnul.set._family_.elEq_.EqDefaulted<T, TEq>
		,
		family.BeI<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public abstract bool be(Family<T> obj);
	}
}
