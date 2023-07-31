using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.unary_.complement_
{

	/// <summary>
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public class Eq8default<TEl,TEq>
		:
		nilnul.obj.Box_ofIn<nilnul.set_.Eq8static<TEl,TEq>>
		,
		nilnul.set.op_.unary_.EqDefaultI<TEl,TEq>
		,
		IComplement<TEl>
		where TEq:IEqualityComparer<TEl>,new()
	{
		/// <summary>
		/// This is the inner state of the op such as to make the op stateful.
		/// The inner state is private, and can be understood as having nothing to do with omega/universal. We can name it "omega" or "t" or "anything else."; it is in its own right, and can be different independently from the universal set where the operands come from.
		/// </summary>
		/// <param name="val"></param>
		public Eq8default(IEnumerable<TEl> val) : base(
			new set_.Eq8static<TEl, TEq>(val
				))
		{
		}

		public HashSet<TEl> omega { get { return boxed; } }

	
		public nilnul.set_.Eq8static<TEl, TEq> op(nilnul.set_.Eq8static<TEl,TEq> par)
		{
			var r = new nilnul.set_.Eq8static<TEl, TEq>(this.omega);
			r.ExceptWith(par);
			return r;

		}

	}
}
