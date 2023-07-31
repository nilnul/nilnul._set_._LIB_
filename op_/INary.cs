using System.Collections.Generic;
using System.Linq;

namespace nilnul.set.op_
{
	/// <summary>
	/// can be stateful, by, for example, wrapping a given set;
	/// </summary>
	/// alias:
	///		constant;
	public interface INary
		:
		set.IOp
	//,
	//nilnul.obj.of_.INary
	{
	}
	public interface NaryI<T>
		:
		INary
		,
		obj.op_.NaryI<HashSet<T>>
	{ }


	public class Nary<T>
		:
		obj.Box_ofIn<HashSet<T>>
		,
		NaryI<T>

	{
		public Nary(in HashSet<T> val) : base(val)
		{
		}

		public Nary(HashSet<T> x) : base(x)
		{
		}

		public HashSet<T> op()
		{
			return boxed;
		}

		public override string ToString()
		{
			var firstFour = boxed.Take(4);

			if (firstFour.Count() < 4)
			{
				return $$"""{{{nilnul.objs._PhraseX._Phrase(firstFour)}}}""";
			}
			return $$"""{{{nilnul.objs._PhraseX._Phrase(firstFour.Take(3))}}}, ...""";

		}
	}



}
