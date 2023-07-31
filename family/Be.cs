using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family
{
	public interface BeI<T>
		:nilnul.obj.BeI1<
			nilnul.set.Family<T>
		>
	{
	}


	public class Be<T> :
		nilnul.obj.Be1<
			nilnul.set.Family<T>
		>
		,
		BeI<T>
	{
		public Be(Func<Family<T>, bool> func) : base(func)
		{
		}

	}
}
