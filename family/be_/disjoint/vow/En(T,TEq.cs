
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;
using nilnul.collection.set.rel;

namespace nilnul.set.family.be_.disjoint.vow
{
	[Obsolete(nameof(Ee_eqDefaulted<T,TEq>))]
	public class En<T, TEq>
		 : nilnul.obj.Box<nilnul.set.Family<T, TEq>>
		where TEq : IEqualityComparer<T>, new()

	{

		public En(nilnul.set.Family<T, TEq> family):base(family)
		{
			_VowX.Vow(family);

		}

		 public nilnul.obj.Set<T, TEq> containerOf( T element)
		{

			foreach (var set in this.boxed)
			{
				if (set.Contains(element))
				{
					return set;

				}


			}
			return null;

		}




		static public nilnul.obj.Set<T, TEq> ContainerOf(IEnumerable<nilnul.obj.Set<T, TEq>> disjointSets, T element)
		{


			foreach (var set in disjointSets)
			{
				if (set.Contains(element))
				{
					return set;

				}


			}
			return null;

		}


	}

	
}



