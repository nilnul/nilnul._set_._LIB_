using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.minterm
{
	/// <summary>
	/// 
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

		private Minterm<T> _minterm;

		public Minterm<T> minterm
		{
			get { return _minterm; }
			set { _minterm = value; }
		}


		public Coefed(HashSet<T> coef_, Minterm<T> minterm0)
		{
			_coef = coef_;

			_minterm = minterm0;
		}

	}
}
