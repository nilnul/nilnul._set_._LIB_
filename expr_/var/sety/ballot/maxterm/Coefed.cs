using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm
{
	/// <summary>
	/// the coef is added, not multiplied, to the other terms;
	/// eg:
	///		{1} union x union !y
	///	so {0} acts like the 1 in coef for minterm.
	///	the omega acts like the 0 in coef for minterm, but we inherently cannot have such omega.
	/// </summary>
	/// alias:
	///		monomial
	public class Coefed<T>
	{
		private HashSet<T> _coef;

		public HashSet<T> coef
		{
			get { return _coef; }
			set { _coef = value; }
		}

		private Maxterm<T> _maxterm;

		/// <summary>
		/// 
		/// </summary>
		/// monic
		public Maxterm<T> maxterm
		{
			get { return _maxterm; }
			set { _maxterm = value; }
		}


		public Coefed(HashSet<T> coef_, Maxterm<T> maxterm0)
		{
			_coef = coef_;

			_maxterm = maxterm0;
		}

		
		public Coefed( Maxterm<T> maxterm0):this(new HashSet<T>(),maxterm0)
		{
		}

		/// <summary>
		/// the coef will make no difference as the maxterm is 0.
		/// </summary>
		/// <param name="coef_"></param>
		public Coefed(HashSet<T> coef_)
			:this(coef_, new Maxterm<T>())
		{
		}


		public Coefed():this( new HashSet<T>())
		{
				
		}

		//public static Coefed<T> Of(Maxterm<T> maxterm)
		//{
		//	return new Coefed<T>(maxterm);
		//}
	}
}
