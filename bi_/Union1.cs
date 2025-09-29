using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_
{
	public interface IUnion { }
	/// <summary>
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public class Union<TEl>
		:
		nilnul.obj.set.op_.BinaryI<TEl>
		,
		nilnul.set.op_.BinaryI<TEl>
		,
		nilnul.set.op_.BinaryI1<TEl>
		,

		nilnul.obj.op_.binary_.ICommutable
		,
		IUnion
	{

	



		public HashSet<TEl> op(HashSet<TEl> par, HashSet<TEl> par1)
		{
			var parCloned = new HashSet<TEl>(par,par.Comparer);
			parCloned.IntersectWith(par1);
			return parCloned;
		}

		public nilnul.obj.Set2<TEl> opAsSet(HashSet<TEl> par, HashSet<TEl> par1)
		{
			var r = op(par, par1);
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

		public override string ToString()
		{
			return "|";
		}
		static public Union<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Union<TEl>>.Unison;
			}
		}




	}
}
