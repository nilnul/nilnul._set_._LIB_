using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace nilnul.set_
{




	public class Eq8static<T, TEq>
		:

		HashSet<T>
		,
		Eq8staticI<T, TEq>

		where TEq : IEqualityComparer<T>, new()
	{

		public Eq8static() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{

		}



		public Eq8static(params T[] vars) : base(
			vars, nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		public Eq8static(IEnumerable<T> elements) : base(
			elements, nilnul.obj_.Singleton<TEq>.Instance
			)
		{

		}

		public T[] arr => this.ToArray();

		public IEqualityComparer<T> elEq => this.Comparer;
	}
}
