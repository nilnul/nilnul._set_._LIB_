using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set
{
	public partial class EqContext<T, TEq>
		where TEq : IEqualityComparer<T>, new()
	{

		static public IEqualityComparer<T> Eq = SingletonByDefaultNew<TEq>.Instance;
		public class Set
			: HashSet<T>
		{
			public Set()
				: base(EqContext<T, TEq>.Eq as IEqualityComparer<T>)
			{

			}


			public class Eq
			: IEqualityComparer<Set>
			{


				public bool Equals(Set x, Set y)
				{

					return x.SetEquals(y);
					throw new NotImplementedException();
				}

				public int GetHashCode(Set obj)
				{

					return 0;
					throw new NotImplementedException();
				}






			}


			public class Add {

				static public Set Eval(Set A,Set B) {
					var r = new Set();
					r.AddRange(A);
					r.AddRange(B);
					return r;

				} 
			}

			static public Set EmptySet = new Set();

		}

		static public Set Sum(IEnumerable<Set> sets) {


			var r = Set.EmptySet;
			foreach (var item in sets)
			{
				r.AddRange(item);
				
			}
			return r;
			
		
		}






		public class SetOfSet
					: EqContext<Set, Set.Eq>.Set
		{




		}





	}
}
