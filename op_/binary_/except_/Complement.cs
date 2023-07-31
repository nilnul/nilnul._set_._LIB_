using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.except_
{
	/// <see cref="ternary_.IConcur"/>, <see cref="ternary_.INeither"/>
	/// <summary>
	/// if the beginning operand is the omega set (<see cref="op_.nary_.IOmega"/>) according to the context;
	/// </summary>
	/// <remarks>
	/// when used in the expr, the beginning arg is invisible, and implicitly prescribed by the context;
	/// </remarks>
	
	public interface IComplement:IExcept {

	}
	/// <summary>
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public class Complement<TEl>
		:
		
		nilnul.set.op_.binary_.Except<TEl>
		,
		IComplement

	{
		
		public const char Symbol = '!'; 

		public override string ToString()
		{
			return Symbol.ToString();
		}

		static public Complement<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Complement<TEl>>.Unison;
			}
		}



	}
}
