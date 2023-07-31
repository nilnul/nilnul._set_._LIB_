using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{

	/// <summary>
	/// alias:delta difference
	///		symmetric difference
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	/// also known as the disjunctive union
	public class Delta<TEl>
		:nilnul.obj.set.op_.BinaryI<TEl>
		,
		nilnul.set.op_.BinaryI<TEl>
		,
		nilnul.set.op_.BinaryI1<TEl>
		,

		nilnul.obj.op_.binary_.ICommutable


		//where TElEq:IEqualityComparer<TEl>,new()
	{
		/// <summary>
		/// with reference to circled plus, which denotes logical Xor
		/// </summary>
		/// <remarks>
		/// sometimes,
		///		∆ is used.
		///		△
		///		<see cref="nilnul.bit.op_.binary_.Ne.TXT"/>
		/// </remarks>
		 const char Symbol = '⊖'; // (U+2296);
		public /*nilnul.obj.Set2*/HashSet<TEl> op(HashSet<TEl> par, HashSet<TEl> par1)
		{
			var r = new HashSet<TEl>(par,par.Comparer);

				r.SymmetricExceptWith(par1);
			return r;
			

			if (par.Comparer == par1.Comparer)
			{
				r.SymmetricExceptWith(par1);
				return r;
			}
			else
			{
				throw new obj.set.co_.sameEq_.xpn_.EqNotSameException(
					$"the eq comparers of {par} and {par1} are not the same"
				);
			}
		}


		public nilnul.obj.Set2<TEl> op(nilnul.obj.Set2<TEl> par, nilnul.obj.Set2<TEl> par1)
		{
			return new obj.Set2<TEl>( op(
				(HashSet<TEl>)par
				,
				(HashSet<TEl>)par1

			));
		}

		public obj.SetI2<TEl> op(nilnul.obj.SetI2<TEl> par, obj.SetI2<TEl> par1)
		{
			return (
				op(
					new nilnul.obj.Set2<TEl>(par,par.memberEq)
					,
					new nilnul.obj.Set2<TEl>(par1, par.memberEq)
				)
			);
		}

		public override string ToString()
		{
			return "^";
		}

		static public Delta<TEl> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Delta<TEl>>.Instance;
			}
		}


	}
}
