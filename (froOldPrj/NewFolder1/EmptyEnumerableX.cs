using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.collection
{
	public partial class EmptyEnumerableX<TElement>
	{

		static public bool IsEmpty(NotNull2<IEnumerable<TElement>> x) {
			return x.val.Count() ==0;
		}

		
		static public bool IsNotNullAndIsEmpty(IEnumerable<TElement> x) {
			return x!=null && x.Count() ==0;
		}

		static public bool IsEmpty(IEnumerable<TElement> x)
		{
			return  IsEmpty(x.ToNotNull());
		}

		static public bool IsNullOrEmpty(IEnumerable<TElement> x)
		{
			return x==null || x.Count() == 0;
		}


		public class Adjective
			:nilnul.bit.Adjective_FroFunc<NotNull2<IEnumerable<TElement>>>
		{

			public Adjective()
				:base(IsEmpty)
			{

			}
					

		}


		public class Empty
			: nilnul.bit.Adjective_FroFunc<NotNull2<IEnumerable<TElement>>>
		{

			public Empty()
				: base(IsEmpty)
			{

			}


		}



		public class AdjectiveAntonym
			:nilnul.bit.Adjective_FroAntonym<NotNull2<IEnumerable<TElement>>,Adjective>
		{ 
		
		}


		public class NotEmpty
			: nilnul.bit.Adjective_FroAntonym<NotNull2<IEnumerable<TElement>>, Adjective>
		{

		}




		public class Assertion
		:nilnul.bit.AssertionFroAdjSingleton<NotNull2<IEnumerable<TElement>>,Adjective>
		{ 

		
		}





		public class Noun
			:nilnul.bit.AdjectiveType<NotNull2<IEnumerable<TElement>>,Adjective>
		{

			public Noun(NotNull2<IEnumerable<TElement>> sequence)
				:base(sequence)
			{
			}

			public Noun(IEnumerable<TElement> seq)
				:this(seq.ToNotNull())
			{
			}
					

					
		}

		public class EmptySequence
	: nilnul.bit.AdjectiveType<NotNull2<IEnumerable<TElement>>, Adjective>
		{

			public EmptySequence(NotNull2<IEnumerable<TElement>> sequence)
				: base(sequence)
			{
			}

			public EmptySequence(IEnumerable<TElement> seq)
				: this(seq.ToNotNull())
			{
			}



		}

		public class NounDual 
		:nilnul.bit.AdjectiveAntonymType<NotNull2<IEnumerable<TElement>>,Adjective>
		{

			public NounDual(NotNull2<IEnumerable<TElement>> seq)
				:base(seq)
			{
			}
					

			public NounDual(IEnumerable<TElement> seq)
				:base(seq.ToNotNull())
			{
			}
					
		}

		public class NotEmptySequence
: nilnul.bit.AdjectiveAntonymType<NotNull2<IEnumerable<TElement>>, Empty>
		{

			public NotEmptySequence(NotNull2<IEnumerable<TElement>> seq)
				: base(seq)
			{
			}


			public NotEmptySequence(IEnumerable<TElement> seq)
				: base(seq.ToNotNull())
			{
			}

		}

		
	}
}
