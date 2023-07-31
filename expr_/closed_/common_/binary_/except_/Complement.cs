using nilnul.set.expr_.var.sety.ballot.maxterm.coefeds_.isovars_.unlike;
using nilnul.set.expr_.var.sety.ballot.minterms;
using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.closed_.common_.binary_.except_
{
	public class Complement<T>
		: closed_.common_.BinaryA<T>
		,
		_call_.OpI
	{
		public Complement(expr_.var_.Omega<T> omega, CommonI<T> arg1) : base(
			nilnul.set.op_.binary_.except_.Complement<T>.Unison,
			omega, arg1
		)
		{
		}
		public override Sop<T> toSop()
		{
			
			var arg2pos = this.arg1.toSop();

			/// complement the pos such as:
			/// xy + x!z
			/// we get:
			/// ! (  xy + x!z  )
			///
			/// 
			///
			///  = !(xy)  &  !(x!z )
			///
			var terms4sum = arg2pos.minterms.Select(
				min=> var.sety.ballot.monomial.op_.unary_.comple_._Minterm2maxtermX.Complement2maxterm(min)
			);

			/// = ( !x | !y )   &   (!x | z)
			///

			var newMinEs = nilnul.obj.str.strung.op_.binary_.cartesian.cumulator.Cumulate<(Var<T>, bool)>.Singleton.cumulate_each2monos(
				terms4sum
			);
			// !x !x | !x z |  !y!x  |  !y z


			var newSum = new expr_.var.sety.ballot.minterms.Sop<T>(
				newMinEs.Select(
					m=>
					var.valves._ProductX.ProductAsMinterm0nul<T>(m)
				).Where(x => x is not null)
			);
			return newSum;






		}



		IOp _call_.OpI.op => base.op;


		public override string ToString()
		{
			return $"{set.op_.unary_._ComplementX.SYMBOL8CHAR}{arg1}";
		}
	}
}
