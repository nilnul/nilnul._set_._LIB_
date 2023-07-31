using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace nilnul.set_
{

	/// <summary>
	/// we can directly use <see cref="IEnumerable{T}"/>
	/// </summary>
	public interface IEq8implicit { }

	public interface Eq8implicitI<T>:IEnumerable<T>,nilnul.SetI1<T> { }



	/// <summary>
	/// the elEq is fixed to be the default; 
	/// </summary>
	/// <typeparam name="T"></typeparam>

	public class Eq8implicit<T>
		:

		HashSet<T>
		,
		nilnul.SetI1<T>
		,
		Eq8implicitI<T>

	{

		public Eq8implicit() : base(EqualityComparer<T>.Default)
		{

		}



		public Eq8implicit(params T[] vars) : base(
			vars, EqualityComparer<T>.Default)
		{
		}

		public Eq8implicit(IEnumerable<T> elements) : base(
			elements,
			EqualityComparer<T>.Default
			)
		{

		}

		//public T[] arr => this.ToArray();

		public IEqualityComparer<T> elEq => this.Comparer;
	}
}
