using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{
	static public class _IntersectX
	{
		static public HashSet<T> Intersect<T>(HashSet<T> x, IEnumerable<T> y) {
			var r = new HashSet<T>(x, x.Comparer);
			r.IntersectWith(y);
			return r;
			
		}

		static public HashSet<T> Intersect<T>(IEnumerable<T> x, IEnumerable<T> y, IEqualityComparer<T> elEq) {

			return new HashSet<T>( x.Intersect(y, elEq),elEq );
			
			
		}

		static public HashSet<T> Intersect<T>(IEnumerable<T> x, IEnumerable<T> y) {

			return Intersect( x,y, EqualityComparer<T>.Default);
			
			
		}


	}

	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		intersect
	///		sect
	///		joint
	///		share
	public interface IIntersect:IBinary { }


}
