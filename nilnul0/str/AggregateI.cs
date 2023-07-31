using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str
{
	public interface AggregateI<T>
		:nilnul.OpI<IEnumerable<T>, T>
	{
	}

	public class Aggregate<T> :
		Op<IEnumerable<T>, T>,
		AggregateI<T>
	{
		public Aggregate(Func<IEnumerable<T>, T> op) : base(op)
		{
		}
	}
}
