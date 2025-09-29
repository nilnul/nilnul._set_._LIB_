using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family
{
	/// <summary>
	/// 
	/// </summary>
	/// unite
	/// unison
	/// uniform
	/// 
	static public class _UniteX
	{
		static public HashSet<T> Unite<T>(
			nilnul.set.Family<T> family
		)
			
		{
			var r = new HashSet<T>(family.elEq);

			family.ForEach(x => r.UnionWith(x));

			return r;
		}

		static public HashSet<T> Unite<T>(
			IEqualityComparer<T> eq
			,
			IEnumerable<IEnumerable<T>> family
		)
			
		{
			var r = new HashSet<T>(eq);

			family.Each(x => r.UnionWith(x));

			return r;
		}

		static public HashSet<T> Unite<T>(
			
			IEnumerable<IEnumerable<T>> family
		)
			
		{
			return Unite(EqualityComparer<T>.Default, family);
		}



		static public HashSet<T> Unite<T>(
			IEqualityComparer<T> eq
			,
			params IEnumerable<T>[] family
		)
		{
			return Unite(eq, (IEnumerable<IEnumerable<T>>)family);
		}

		static public HashSet<T> Unite<T>(
			
			params IEnumerable<T>[] family
		)
		{
			return Unite(EqualityComparer<T>.Default, (IEnumerable<IEnumerable<T>>)family);
		}

		static public HashSet<T> Unite<T,TEq>(
			params IEnumerable<T>[] family
		)
			where TEq :IEqualityComparer<T>,new()
		{
			return Unite(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
				, (IEnumerable<IEnumerable<T>>)family);
		}

		static public HashSet<T> Unite<T,TEq>(
			IEnumerable< IEnumerable<T>> family
		)
			where TEq :IEqualityComparer<T>,new()
		{
			return Unite(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
				, (IEnumerable<IEnumerable<T>>)family);
		}

		static public HashSet<T> Unite<T>(
			HashSet< HashSet<T> > family
			,
			IEqualityComparer<T> elEq
		)
			
		{
			return Unite(new Family<T> (elEq, family));
		}


		static public HashSet<T> Unite<T>(
			IEqualityComparer<T> elEq
			,
			HashSet< HashSet<T> > family
		)
			
		{
			return Unite(elEq, (IEnumerable<HashSet<T>>) family);
		}



	}
}
