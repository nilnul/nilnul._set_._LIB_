using nilnul.obj.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.delta.cumulator.be_
{
	/// <summary>
	/// 单位元（注意不是零元）是 空集
	/// </summary>
	public class LeftUnard<TEl>
		:
		nilnul.obj.op_.binary.cumulator.be_.ILeftUnard
		,
		nilnul.obj.BeI1
		<
			delta.Cumulator<TEl>


		>
	{
		public bool _be_assumeDwelt(Cumulator<TEl> obj)
		{
			/// the empty set  (delta) with a set <var>x</var>, and the result is <var>x</var>
			return true;
			throw new NotImplementedException();
		}
	}
}
