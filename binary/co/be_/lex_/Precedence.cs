using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary.co.be_.lex_
{
	/// <summary>
	/// eg:
	///		for 
	///			x+y*z
	///		,
	///		the two operators: +, *
	///			have to be determined which takes precedence in lexer (both phrase and parse), resulting semantically either (x+y)*z, or x+(y*z).
	///			
	///	
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class Precedence
	{
		public readonly Type[][] priority = new Type[][] {
			new Type[]{
				typeof(op_.binary_.except_.IComplement) /// for complement op, we wouldnot proceed further to <see cref="op_.binary_.IExcept"/>
				,
			}
			,

			new Type[]{
				typeof(op_.binary_.IIntersect)
				,
			}
			,
			new Type[]{
				typeof(op_.binary_.IUnion)
				,
				typeof(op_.binary_.IDelta)
				,
			}
			,
			new Type[]{
				typeof(op_.binary_.IExcept)
			}
			,
			new Type[]{
				typeof(op_.binary_.IConcur)
			}

		};

		/// <summary>
		/// default is left associative.
		/// </summary>
		public readonly Type[] rightAssociativity = new Type[]{

		};

		/// <summary>
		/// 
		/// </summary>
		/// <param name="op">the primary op, which is the op for the whole expr</param>
		/// <param name="op1">the op of the arg; but for binary op, and for previous arg, this is the expr op, and <paramref name="op"/> is the arg op.</param>
		/// <returns></returns>
		public bool be(nilnul.set.op_.IBinary op, nilnul.set.op_.IBinary op1) {
			var type0 = op.GetType();
			var index = priority.FindIndex(
				o => o.Any(
					t =>t.IsAssignableFrom(type0)
				)
			);

			var index1 = priority.FindIndex(
				o => o.Any(
					t =>	t.IsAssignableFrom(
						op1.GetType()
					)
				)
			);
			if (index<0)
			{
				if (index1<0)
				{
					return true; //left associative
				}
				return false;
			}

			if (index==index1)
			{
				return rightAssociativity.Any(t=> t.IsAssignableFrom(type0)); /// the right operand shall be associated to the right.
			}
			return index < index1;
		}


		static public Precedence Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Precedence>.Unison;
			}
		}

	}
}
