using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot
{
	public interface IMaxterm:IMonomial { }

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Maxterm<T>
		:
		nilnul.obj.Box_ofIn<sety.Ballot<T>>
		,
		IMaxterm
	{

		public sety.Ballot<T> ballot { get {
				return this.boxed;
		} }
		public Maxterm(in Ballot<T> val) : base(val)
		{
		}

		public Maxterm(Ballot<T> x) : base(x)
		{
		}

		/// <summary>
		/// this is sum(), which is the empty set.
		/// </summary>
		public Maxterm():this(new Ballot<T>())
		{
				
		}

		public static Maxterm<T> Of(Var<T> var)
		{
			return new Maxterm<T>(
				Ballot<T>.Of(var)
			);
		}
	}

}
