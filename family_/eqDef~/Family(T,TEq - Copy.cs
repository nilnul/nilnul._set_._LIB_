using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.set
{
	[Obsolete(nameof(nilnul.set.family_.EqDefaulted<T,TEq>))]
	public class Family<T, TEq> :

		nilnul.obj.Set<nilnul.obj.Set<T, TEq>, nilnul.obj.set.Eq1<T, TEq>>

		where TEq : IEqualityComparer<T>, new()

	{

		public Family(IEnumerable<obj.Set<T, TEq>> enumerable):base(enumerable)
		{
		}
	}
}
