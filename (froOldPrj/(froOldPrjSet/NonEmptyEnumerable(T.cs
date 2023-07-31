using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set
{
	public partial class NonEmptyEnumerable<T>
		:IEnumerable<T>
	{
		private NotNull2<IEnumerable<T>> _val;

		public NotNull2<IEnumerable<T>> val
		{
			get { return _val; }
			set {
				NonEmptyX.PredicateOfIEnumerable.assert(value.val.Cast<object>());

				_val = value; 
			}
		}


		public NonEmptyEnumerable(NotNull2<IEnumerable<T>> x)
		{

			this.val = x;
		}

		public NonEmptyEnumerable(IEnumerable<T> x)
			:this(
				new NotNull2<IEnumerable<T>>(x)
			)
		{
		}
					
					
		
		public IEnumerator<T> GetEnumerator()
		{
			return _val.val.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
