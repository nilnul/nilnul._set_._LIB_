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
	public class Magma_byIndex<T> : nilnul.set.family.BeI<T>
		,
		delta.BeI_ofFamily<T>
	{
		public bool be(Family<T> obj)
		{

			if (obj.Any())
			{
				return dwelt_.Magma_byIndex<T>.Singleton. _be_assumeDwelt(obj);


			}
			else
			{
				return true;

			}


		}


		static public Magma_byIndex<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Magma_byIndex<T>>.Instance;
			}
		}

	}
}
