using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.str.to
{
	public partial class Txt
	{
		static public string Eval_parenthesisRound<T>(IEnumerable<T> x) {
			return string.Format("({1})",collection.to.Txt.Eval(x));
		}
		static public string Eval_bracketSquare<T>(IEnumerable<T> x) {
			return string.Format("[{1}]",collection.to.Txt.Eval(x));
		}
			static public string Eval_braceCurly<T>(IEnumerable<T> x) {
			return string.Format("{{{1}}})",collection.to.Txt.Eval(x));
		}
}
}
