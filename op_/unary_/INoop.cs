using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.unary_
{



	/// <summary>
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public interface INoop<TEl>
		:
		nilnul.set.op_.IUnary<TEl>

	{


	}
	public interface NoopI<TEl>
		:
		nilnul.set.op_.UnaryI1<TEl>
		,
		INoop<TEl>

	{


	}
	public class Noop<T> : NoopI<T>
	{
		public HashSet<T> op(HashSet<T> par)
		{
			return par;
		}


		static public Noop<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Noop<T>>.Unison;
			}
		}

	}


}
