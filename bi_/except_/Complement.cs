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
	/// so complemet looks like a <see cref="IUnary"/>, but it's not. It's binary, and one operand is contextual and implicit. As the result, in language, when we say not or antonym, the contextual implicit universal omega must be defined, otherwise a paradox such as those similar to Russell pardox might arise;
	/// eg:
	///		in Regex [^\w], the universe is all the unicode characters;
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
