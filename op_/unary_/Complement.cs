using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.unary_
{
	static public class _ComplementX
	{
		public const char SYMBOL8CHAR = '!'; /// like the bit not; note: ~ is taken by <see cref="binary_._ConcurX"/>
	}


	/// <summary>
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public class Complement<TEl>
		:
		nilnul.obj.Box1<HashSet<TEl>>
		,
		nilnul.set.op_.UnaryI<TEl>
		,
		nilnul.set.op_.UnaryI1<TEl>

		,
		IComplement<TEl>
	{
		/// <summary>
		/// This is the inner state of the op such as to make the op stateful.
		/// The inner state is private, and can be understood as having nothing to do with omega/universal. We can name it "omega" or "t" or "anything else."; it is in its own right, and can be different independently from the universal set where the operands come from.
		/// </summary>
		/// <param name="val"></param>
		public Complement(HashSet<TEl> val) : base(val)
		{
		}

		public HashSet<TEl> omega { get { return boxed; } }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="par">can be non-subset of boxed, including a superset, or a set of some members outside boxed.</param>
		/// <returns></returns>
		public HashSet<TEl> opAsHashSet(IEnumerable<TEl> par)
		{
			var r = new HashSet<TEl>(boxed, boxed.Comparer);
			r.ExceptWith(par);
			return r;
		}

		public HashSet<TEl> opAsHashSet(HashSet<TEl> par)
		{
			return opAsHashSet( (IEnumerable<TEl>) par);
		}

		public HashSet<TEl> opAsHashSet(obj.SetI2<TEl> par)
		{
			return opAsHashSet( (IEnumerable<TEl>) par);
			
		}

		public obj.Set2<TEl> opAsSet(obj.SetI2<TEl> par)
		{
			return new obj.Set2<TEl>( opAsHashSet(par));

		}
		public obj.SetI2<TEl> op(obj.SetI2<TEl> par)
		{
			return  opAsSet(par);

		}

		public HashSet<TEl> op(HashSet<TEl> par)
		{
			return nilnul.set.op_. binary_._ExceptX.Except(omega,par);
		}
	}
}
