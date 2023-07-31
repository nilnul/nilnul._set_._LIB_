using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{

	/// <summary>
	/// complement of the delta;
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public class Concur<TEl>
		:
		nilnul.obj.Box1<HashSet<TEl>>,
		nilnul.obj.set.op_.BinaryI<TEl>
		,
		nilnul.set.op_.BinaryI<TEl>
		,
		nilnul.set.op_.BinaryI1<TEl>
		,
		nilnul.obj.op_.binary_.ICommutable


	{
		public Concur(HashSet<TEl> val) : base(val)
		{
		}

		/// <summary>
		/// for the unison of a fmily, it's called Universe, not Omega.
		/// </summary>
		/// 	Universal might be different from Omega.

		public HashSet<TEl> omega
		{
			get
			{
				return boxed;
			}
		}

		public obj.Set2<TEl> omegaAsSet
		{
			get
			{
				return new obj.Set2<TEl>(boxed);
			}
		}



		/// <summary>
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="par">
		/// if it is empty, then the result is complement of <paramref name="par1"/>
		/// </param>
		/// <returns>
		/// the result is never outside Omega.
		/// 
		/// if one operand is empty, then the result is the complement of the other.
		/// if one operand is omega, then the result is the other intersected by omega, which might be different from the other par itself. so omega might be not a neutral element. To know whether it's neutral, we need to:
		///		either the omega includes all instances of the <typeparamref name="TEl"/>
		///		or the operands come from a univ that is subset of Omega.
		///		So we defer this discussion to <see cref="family.algebra_.pargoid_.IConcur{T}"/>
		///
		/// the operation on reflex co, is the omega
		/// if one par is the supset of the other par, the result is the subset, and the complement of the supset.
		/// if the co is complement to each other, then the result is empty.
		///  
		/// </returns>
		public HashSet<TEl> op(HashSet<TEl> par, HashSet<TEl> par1)
		{
			// or throw xpn if operands exceed omega?

			var intersected = binary_.sect.cascader._CascadeX.Conjunct<TEl>(boxed, par, par1);


			var complementedIntersected = binary_.except._SubsumeX.ExceptAsNew(
				boxed
				,
				par
				,
				par1
			);

			intersected.AddRange(
				complementedIntersected
			);
			return intersected;

		}
		public HashSet<TEl> opAsHashset(HashSet<TEl> par, HashSet<TEl> par1)
		{
			
			return op(par,par1);

		}

		public nilnul.obj.Set2<TEl> opAsSet(HashSet<TEl> par, HashSet<TEl> par1)
		{
			var r = opAsHashset(par, par1);
			return new obj.Set2<TEl>(r, r.Comparer);

		}

		public nilnul.obj.Set2<TEl> op(nilnul.obj.Set2<TEl> par, nilnul.obj.Set2<TEl> par1)
		{
			return opAsSet(
				(HashSet<TEl>)par
				,
				(HashSet<TEl>)par1

			);
		}

		public obj.SetI2<TEl> op(nilnul.obj.SetI2<TEl> par, obj.SetI2<TEl> par1)
		{
			return (
				op(
					new nilnul.obj.Set2<TEl>(par, par.memberEq)
					,
					new nilnul.obj.Set2<TEl>(par1, par.memberEq)
				)
			);
		}





	}
}
