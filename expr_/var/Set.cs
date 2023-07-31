using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// alias:
	///		set
	///		setty
	///			, euphemism for set, as there is already a seg named "set" in the preceding namespace: <see cref="nilnul.set.expr_.var"/>
	///		setto
	public class Set<T> :
		nilnul.set_.Eq8static<Var<T>, obj.expr_.var.Eq>
	{
		public Set()
		{
		}

		public Set(IEnumerable<Var<T>> vals) : base(vals)
		{
		}
	}
}
