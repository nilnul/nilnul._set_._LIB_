using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.be_
{
	/// <summary>
	/// a family of sets is a topology if:
	///		1) the family is closed over the nullary operator of omega (the universal set)
	///			also closed over the nullary operator of phi the empty set.
	///		2) closed over arbitrary union (sigma, or cumulated union, of a subset of the family)
	///			for finite family, union implies arbitrary union
	///		3)  intersection.
	///			implying closure over finite intersection, as repeatedly intersection resulted that the set is member of the family.
	/// member of topology is also called open. and the complement of open set is called closed. a closed set might be member of the family, thus being both closed and open
	/// </summary>
	static public class _TopoX
	{
		static public bool Be<T, TEq>(nilnul.set.Family<T, TEq> family)
			where TEq : IEqualityComparer<T>, new()
		{
			var universe = nilnul.set.family._UnionX.Union(family);

			return
				family.Contains(new obj.Set<T, TEq>())	//包含空集
				&&

				family.Contains(new obj.Set<T, TEq>(universe))		//包含 全集
				&&
				nilnul.set._CombinateX.Combinate(family, 2).All(
					x =>
						family.Contains(
							new obj.Set<T, TEq>(
								nilnul.set.op_.binary_.Union<T, TEq>.Singleton.op(
									new Set1<T, TEq>(
										x.First()
									)
									,
									new Set1<T, TEq>(
										x.Last()
									)
								)
							)
						)		// unioned is in

						&&
						family.Contains(
							new obj.Set<T, TEq>(
								nilnul.set.op_.binary_.Intersect<T, TEq>.Singleton.op(
									new Set1<T, TEq>(
										x.First()
									)
									,
									new Set1<T, TEq>(
										x.Last()
									)
								)
							)
						)	// intersected is in
				)
			 ;
		}
	}
}