using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.pargoid_.delta.be_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///		
	public class Magma_byCombi<T> : nilnul.set.family.BeI<T>
		,
		delta.BeI_ofFamily<T>
	{
		public bool _be_assumeDwelt(Family<T> obj)
		{


			if (!obj.Contains(
				new HashSet<T>(
				obj.First().Comparer
			)))
			{
				return false;
			}


			//has phi the empty set.

			var combinated = nilnul.set.family.op_.of_.set_.combinate_._ByIndexsX.Family(obj, 2);

			foreach (var item in combinated)
			{
				if (
					!obj.Contains(
						nilnul.set.op_.binary_.Delta<T>.Singleton.op(
							item.First(), item.Last()
						)
					)
				)
				{
					return false;
				}
			}
			return true;
		}

		public bool be(Family<T> obj)
		{

			if (obj.Any())
			{
				return _be_assumeDwelt(obj);
			}

			
			return true;
		}

	}
}
