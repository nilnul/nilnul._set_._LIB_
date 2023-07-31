using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.pargoid_.delta.be_.dwelt_.magma_
{
	/// <summary>
	/// abelian group
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///		
	public class Abelian<T> : nilnul.set.family.BeI<T>
		,
		delta.BeI_ofFamily<T>
	{
		//[Conditional("DEBUG")]
		public bool _be_assumeDweltMagma(Family<T> obj)
		{

			/// 
			/// the magma is semigrp, as <see cref="set.op_.binary_.IDelta"/> is associative
			///

			/// then to make the semigrp a monoid:
			///		if it's not empty, there must be one element. For this element, it deltas itself would be empty element. As the albebra is closed, then the empty element is inside.
			///
			/// now that it's a monoid, every element has itself as the inverse, so it's group.
			///
			/// and it is abelian group, cuz delta is symmetric.
			/// 
			///

			
			return true;
		}

		public bool be(Family<T> obj)
		{

			return be_.dwelt_.Magma_byIndex<T>.Singleton.be(obj);
		}


		static public Abelian<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Abelian<T>>.Instance;
			}
		}



	}
}
