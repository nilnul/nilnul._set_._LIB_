using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection
{
	/// <summary>
	/// finite sequence of objects.
	/// </summary>
	public partial interface StrI
	{
	}

	/// <summary>
	/// must be finite
	/// </summary>
	/// <typeparam name="T"></typeparam>

	public partial interface StrI<T> 
	:IEnumerable<T>
	{ 


	
	}

	public abstract class StrA<T>:StrI<T>
	{

		public abstract IEnumerator<T> GetEnumerator()
;
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
