using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{

	/// <summary>
	/// based on <see cref="nilnul.set.op_.unary_.IComplement{TEl}"/>. Analog to <see cref="op_.unary_.IComplement{TEl}"/>, take in an inner state of the Omega. The omega can be named any name besides omega if that's confusing, And the op is independent and in its own right; the inner state has nothing to do operands, which might come from another universe.
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public class Concur_ofComplement<TEl>
		:
		nilnul.obj.Box1<op_.unary_.Complement<TEl>>
		,
		nilnul.obj.set.op_.BinaryI<TEl>
		,
		nilnul.set.op_.BinaryI<TEl>
		,
		nilnul.obj.op_.binary_.ICommutable


	{
		public Concur_ofComplement(unary_.Complement<TEl> val) : base(val)
		{
		}

		public Concur_ofComplement(HashSet<TEl> val) : this(new unary_.Complement<TEl>(val) )
		{
		}

		/// <summary>
		/// for the union all of a fmily, it's called Universe, not Omega.
		/// </summary>
		/// 	for the union all of a fmily, it's called Universe, not Omega.
		/// 	Universal might be different from Omega.

		public HashSet<TEl> omega {
			get{
				return boxed.omega;}
		}

		public obj.Set2<TEl> omegaAsSet {
			get{
				return new obj.Set2<TEl>(omega);
			}
		}



		/// <summary>
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="par">
		/// if it is empty, then the result is <paramref name="par1"/>
		/// </param>
		/// <returns>
		/// the result is never outside Omega.
		///
		///  
		/// </returns>

		public HashSet<TEl> opAsHashset(HashSet<TEl> par, HashSet<TEl> par1)
		{
			var intersected = binary_.sect.cumulator._CumulateX.Intersect<TEl>(boxed.omega, par, par1);


			var complementedIntersected = binary_.except._SubsumeX.ExceptAsNew(
				boxed.omega
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

		public nilnul.obj.Set2<TEl> opAsSet(HashSet<TEl> par, HashSet<TEl> par1)
		{
			var r = opAsHashset(par, par1);
			return new obj.Set2<TEl>( r,r.Comparer  );

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
					new nilnul.obj.Set2<TEl>(par,par.memberEq)
					,
					new nilnul.obj.Set2<TEl>(par1,par.memberEq)
				)
			);
		}


		


	}
}
