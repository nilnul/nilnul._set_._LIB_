using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr_.typed_;
using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.call_.ternary_
{
	/// <summary>
	/// nor;
	/// neither;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Neither<T>
		:
		CurriableA<T>
		,
		closed_.CallI<T>
	{
		


		public Neither(
			expr_.var_.Omega<T> omega
			, CallI<T> arg
			, CallI<T> arg1

			)
			: base(
			nilnul.set.op_.ternary_.Neither<T>.Unison
				  ,
			omega
			, arg, arg1
		)
		{
		}

		public Neither(
			expr_.var_.Omega<T> omega
			,
			ParameterExpression x
			,
			ParameterExpression y
		)
		: base(
			nilnul.set.op_.ternary_.Neither<T>.Unison
			  ,
			  omega
			  ,
			new set.expr_.Var<T>(
				x
			)
			  ,
			new set.expr_.Var<T>(
				y
			)
		)
		{
		}

		public override CommonI<T> toCommon()
		{
			return new closed_.common_.binary_.except_.Complement<T>(
				this.omega
				,
				new closed_.common_.binary_.Union<T>(
					this.arg1.toCommon(),this.arg2.toCommon()
				)
			);
		}


	

	}
}
