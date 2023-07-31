using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// introducing two op:
	///		intersect, union.
	///		
	///		This is not a algebra field. It's in fact an algebra ring.
	///		We can simply call it algebra or ring.
	///		<see cref="nilnul.set.abgebra_.cobiop_.delta9sect_.rng_.IRing"/>
	///		
	public class Field<T> : nilnul.set.family.BeI<T>
	{
		public bool be(Family<T> obj)
		{
			///first, Omega is in F.
			///
			var omega = family._UniteX.Unite(obj);
			///for finite family, we can do this. for infite ones, we don't know whether we can do this; if we cannot do, the omega must be explictly given.

			if (!obj.Contains(omega))
			{
				return false;
			}

			if (
				!obj.All(
					s => obj.Contains(
						nilnul.set.op_.binary_._ExceptX.Except(omega, s)
					)
				)	//complement is in
			) return false;

			var combinated = nilnul.set.family.op_.of_.set_.combinate_._ByIndexsX.Family(obj, 2);

			foreach (var item in combinated)
			{
				if (
					!obj.Contains(
						nilnul.set.family._UniteX.Unite(item, obj.elEq)
					)
				)
				{
					return false;
				}
				#region due to deMorgan Law, this is unnecessary
#if false
				if (
					!obj.Contains(
						nilnul.set.family._IntersectX.Intersect(item, obj.elEq)
					)
				)
				{
					return false;
				}
#endif
				#endregion
			}
			return true;
		}
	}
}
