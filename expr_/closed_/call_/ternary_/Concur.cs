using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr_.typed_;
using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Globalization;
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
	public class Concur<T>
		:

CurriableA<
	T

	>
		,
		closed_.CallI<T>
	{
		


		public Concur(
			expr_.var_.Omega<T> omega
			,
			CallI<T> arg
			, CallI<T> arg1

			)
			: base(
			nilnul.set.op_.ternary_.Concur<T>.Unison
				  ,
			omega
			, arg, arg1
		)
		{
		}

		public Concur(
			expr_.var_.Omega<T> omega
			,
			expr_.Var<T> x
			,
			expr_.Var<T> y
		)
		: base(
			nilnul.set.op_.ternary_.Concur<T>.Unison
			  ,
			  omega
			  ,

				x

			  ,

				y

		)
		{
		}
		public Concur(
			expr_.var_.Omega<T> omega
			,
			ParameterExpression x
			,
			ParameterExpression y
		)
		: base(
			nilnul.set.op_.ternary_.Concur<T>.Unison
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
			return new closed_.common_.binary_.Union<T>(
				new ternary_.Neither<T>(
					this.omega
					,
					this.arg1, this.arg2
				).toCommon()

				,
				new closed_.common_.binary_.Intersect<T>(
					this.arg1.toCommon(), this.arg2.toCommon()
				)
			);
		}



		IOp _call_.OpI.op => base.op;


	}
}
