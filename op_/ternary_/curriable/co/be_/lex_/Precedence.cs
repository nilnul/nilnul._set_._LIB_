using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.ternary_.curriable.co.be_.lex_
{
	/// <summary>
	/// for pseudo-binary ops;
	///
	/// for real ternary op, no precedence is used, as the phrase is linear, and we have only TWO adjacent terms for an op. For ternary, we need to use "()" to establish a tree struc.
	///			
	///	
	/// </summary>
	public class Precedence
	{
		/// <summary>
		/// x~y!|z
		/// </summary>
		public readonly Type[][] priority = new Type[][] {
			new Type[]{
				typeof(op_.ternary_.IConcur) // like "~", which is the dual for "^"
				,
			}
			,
			new Type[]{
				typeof(op_.ternary_.INeither) /// like nor, which is the dual for "|"
			}

		};

		/// <summary>
		/// default is left associative.
		/// </summary>
		public readonly Type[] rightAssociativity = new Type[]{

		};

		public bool be(nilnul.set.op_.ternary_.IContextCurried op, nilnul.set.op_.ternary_.IContextCurried op1) {

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
