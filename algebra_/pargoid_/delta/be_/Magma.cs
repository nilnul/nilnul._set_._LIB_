using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.algebra_.pargoid_.delta.be_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///		
	public class Magma_byRechoose<T> : nilnul.set.family.BeI<T>
		,
		delta.BeI_ofFamily<T>
	{
		public bool be(Family<T> obj)
		{

			foreach (var item in obj)
			{
				foreach (var item1 in obj)
				{
					if (!obj.Contains(
							nilnul.set.op_.binary_.Delta<T>.Singleton.op(
							 item,item1
							)
						 )
					)
					{
						return false;

					}
				}
			}
			return true;
			

		}
	}
}
