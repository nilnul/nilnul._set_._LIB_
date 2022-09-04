using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set
{
	/// <summary>
	/// all the instances of T
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class SetFroHashSetOfDefaultEq<T>
		:HashSet<T>
	{

		public SetFroHashSetOfDefaultEq()
		{
		}


		public void AddRange(IEnumerable<T> elements) {
			if (elements==null)
			{
				return;
			}
			foreach (var item in elements)
			{
				Add(item);
				
			}
		}

		
					
					
	}
}
