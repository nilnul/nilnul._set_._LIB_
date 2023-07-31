using nilnul.obj.str;
using nilnul.set.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op.co.be_.lex_
{
	/// <summary>
	/// eg:
	///		for 
	///			!x+y
	///		,
	///		the two operators: !,+
	///			have to be determined which takes precedence in lexer (both phrase and parse), resulting semantically either (!x)+y, or !(x+y).
	///			
	///	
	/// </summary>
	/// 
	public class Precedence
	{

		/// <summary>
		/// recall that <see cref="nilnul.set.op_.ternary_.Concur{TEl}"/>, often imagined as binary, is in fact ternary; and we have two such  ternary ops that are also pseudo-binary, among which comparison is needed.
		/// </summary>
		/// <param name="former"></param>
		/// <param name="latter"></param>
		/// <returns></returns>
		public bool be(nilnul.set.IOp former, nilnul.set.IOp latter)
		{

			switch (former)
			{
				case set.op_.INary n:
					return true;

				case set.op_.IUnary u:
					return be(u, latter);
				case set.op_.IBinary b:
					return be(b, latter);
				case set.op_.ITernary t:
					return be(t, latter);


			}
			/// now that former is 4orMore nary, this method cannot be called for the left op expression; hence it's called for the right par.

			return false; // hence we need "()" for the left arg.  quarternary or more-arity is less precedent to other ops that are presumably three or less aritied;
		}

		public bool be(ITernary left, IOp right)
		{
			switch (right)
			{
				//case set.op_.INary n:
				//	return false;

				//case set.op_.IUnary u:
				//	return false;
				//case set.op_.IBinary b:
				//	return false;
				case set.op_.ITernary t:
					return be(left, t);


			}

			/// now that right is 4orMore nary, this method cannot be called for the right op expression; hence it's called for the left par.
			return false; // hence we need "()" for the right


		}

		public bool be(ITernary left, ITernary right)
		{
			switch (left)
			{
				case nilnul.set.op_.ternary_.IContextCurried leftAsCurry:
					return be(leftAsCurry, right);


				default:

					switch (right)
					{
						case nilnul.set.op_.ternary_.IContextCurried rightAsCurry:
							return be(left, rightAsCurry);
						default:

							break;
					}

					/// eg:
					///		sum( prod(), prod() )
					///
					throw new InvalidOperationException("for polynary operators: precedence concept is not applicable. eg: sum(x, y+z), where each operands is not parenthesized and separated by ',';");
					break;
			}
		}

		/// <summary>
		///  for a <see cref="op_.ternary_.IContextCurried"/>, we want to know about the right parameter.
		/// </summary>
		/// <remarks>
		/// for noncurriable ternary op, the count of inputs are 3, not 2.
		/// in that case such as: sum(x,y,z), no parenthesis is need as "," is less precedent.
		/// </remarks>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public bool be(set.op_.ternary_.IContextCurried left, ITernary right)
		{

			switch (right)
			{
				case nilnul.set.op_.ternary_.IContextCurried rightAsCurry:
					return set.op_.ternary_.curriable.co.be_.lex_.Precedence.Unison.be(left, rightAsCurry);

				default:
					return true; // the right needs a parenthesis. 
					break;
			}

		}
		/// <summary>
		/// call for an expr with <paramref name="right"/> as op;
		/// </summary>
		/// <remarks>
		/// for noncurriable ternary op, the count of inputs are 3, not 2.
		/// in that case such as: sum(x,y,z), no parenthesis is need as "," is less precedent.
		/// 
		/// </remarks>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public bool be(ITernary left, set.op_.ternary_.IContextCurried right)
		{
			switch (left)
			{
				case nilnul.set.op_.ternary_.IContextCurried leftAsCurry:
					return set.op_.ternary_.curriable.co.be_.lex_.Precedence.Unison.be(leftAsCurry, right);


				default:
					return false; //  the left needs a parenthesis; 
					break;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="u">
		/// as the op in expr
		/// </param>
		/// <param name="latter">as the op in arg</param>
		/// <returns></returns>
		public bool be(IUnary u, IOp latter)
		{
			switch (latter)
			{
				case set.op_.INary:
					return false;
				case set.op_.IUnary: //eg: !!x ; as here all set unary ops are placed before operand.
					return false;
				case set.op_.IBinary b:
					return true; // "()" needed
				case set.op_.ITernary b:
					return true; // "()" needed
					//return be(u, b);

			}
			return true;
		}

		public bool be(nilnul.set.IOp op, nilnul.set.op_.IBinary op1)
		{

			switch (op)
			{
				case set.op_.INary n:
					return true;
				case set.op_.IUnary:
					return true;
				case set.op_.IBinary b:
					return op_.binary.co.be_.lex_.Precedence.Unison.be(b, op1);
			}


			return false; //;
		}
		public bool be(nilnul.set.op_.IBinary op, nilnul.set.IOp op1)
		{

			switch (op1)
			{
				case set.op_.INary n:
					return false;
				case set.op_.IUnary:
					return false;
				case set.op_.IBinary b:
					return op_.binary.co.be_.lex_.Precedence.Unison.be(op, b);
			}


			return true; //default is the left takes precedence;
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
