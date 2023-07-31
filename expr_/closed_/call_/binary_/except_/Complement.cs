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

namespace nilnul.set.expr_.closed_.call_.binary_.except_
{
	public class Complement<T>
		: closed_.call_.BinaryA<T>
		,
		_call_.OpI
	{

		public set.expr_.var_.Omega<T> omega
		{
			get { return (set.expr_.var_.Omega<T>) base.arg; }
		}

		public Complement(expr_.var_.Omega<T> omega, CallI<T> arg1) : base(
			nilnul.set.op_.binary_.Except<T>.Unison,
			omega,
			 arg1
		)
		{
		}

		IOp _call_.OpI.op => base.op;


		public override CommonI<T> toCommon()
		{
			return	new closed_.common_.binary_.except_.Complement<T>(
				this.omega
				,
				arg.toCommon()
			);
		}

		public override string ToString()
		{
			var argAsTxt = arg.ToString();
			if (nilnul.set.op.co.be_.lex_.Precedence.Unison.be(op,arg.op))
			{
				argAsTxt = $"({arg})";
			}
			return $"{set.op_.unary_._ComplementX.SYMBOL8CHAR}{argAsTxt}";
		}
	}
}
