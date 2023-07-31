
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;
using nilnul.collection.set.rel;

namespace nilnul.set.family.be_.disjoint.vow
{
	static public class _EeX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="eq"></param>
		/// <param name="disjointSets"></param>
		/// <param name="element"></param>
		/// <returns>nulable</returns>
		static public IEnumerable<T> ContainerOf<T>(
			IEqualityComparer<T> eq
			,
			IEnumerable<IEnumerable<T>> disjointSets
			,
			T element
		)
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
		static public HashSet<T> ContainerOf<T>(
			IEqualityComparer<T> eq
			,
			nilnul.set.Family<T> disjointSets
			,
			T element
		)
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

		static public IEnumerable<T> ContainerOf<T,TEq>(
			
			IEnumerable<IEnumerable<T>> disjointSets
			,
			T element
		)
			where TEq:IEqualityComparer<T>,new()
		{
			return ContainerOf<T>(nilnul.obj_.Singleton<TEq>.Instance, disjointSets, element);
		}
		static public HashSet<T> ContainerOf<T,TEq>(
			
			nilnul.set.Family<T> disjointSets
			,
			T element
		)
			where TEq:IEqualityComparer<T>,new()
		{
			return ContainerOf<T>(nilnul.obj_.Singleton<TEq>.Instance, disjointSets, element);
		}


	}

	public class Ee<T>
		 : nilnul.set.family.vow.Ee<T>

	{
		public Ee(IEqualityComparer<T> elEq,nilnul.set.Family<T> family ):base(family, new disjoint.Vow<T>(elEq))
		{

		}

		 public HashSet<T> containerOf( T element)
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


	}

	public class Ee_eqDefaulted<TEl, TEq>
		: Ee<TEl>
		where TEq : IEqualityComparer<TEl>, new()
	{
		public Ee_eqDefaulted(
			Family<TEl> family
		)
			:
		base(
			nilnul.obj_.Singleton<TEq>.Instance, family
		)
		{
		}
	}

}



