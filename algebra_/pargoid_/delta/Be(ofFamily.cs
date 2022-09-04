using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.algebra_.pargoid_.delta
{
	public interface BeI_ofFamily<T>
		:nilnul.set.family.BeI<T>
		,
		nilnul.obj.IBe<IDelta<T>>
	{
	}
}
