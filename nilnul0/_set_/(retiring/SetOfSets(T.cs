using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set
{
	//alias for set.Set<set.Set<T,TEq>, set.Eq<T,TEq> >
	public class SetOfSets<TElementOfElement>
				: set.Set<set.Set<TElementOfElement>>

	{
		public SetOfSets(IEqualityComparer<TElementOfElement> elementEq)
			
			:base(new Set<TElementOfElement>.Eq(elementEq))
		{



		}
		public SetOfSets(IEnumerable<set.Set<TElementOfElement>> sets)
			: base(sets)
		{



		}
		public SetOfSets(IEqualityComparer<TElementOfElement> elementOfElementEq, IEnumerable<set.Set<TElementOfElement>> sets)
			: base(sets,new Set<TElementOfElement>.Eq(elementOfElementEq))
		{



		}

		





	}

	public class SetOfSets<TElementOfElement,TElementOfElementEq>
		:SetOfSets<TElementOfElement>
		where TElementOfElementEq:IEqualityComparer<TElementOfElement>,new()
	{
		public SetOfSets():base(SingletonByDefaultNew<TElementOfElementEq>.Instance)
		{

		}

	}

	public class SetOfSets_defaultElementElementEq<TElementOfElement>
		:SetOfSets<TElementOfElement,nilnul.obj.DefaultEq<TElementOfElement>>
	{


	}

	
}
