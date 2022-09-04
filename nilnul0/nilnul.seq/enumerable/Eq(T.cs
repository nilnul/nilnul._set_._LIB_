using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.enumerable
{
	public partial class Eq<T>
		:IEqualityComparer<IEnumerable<T>>
	{
		private IEqualityComparer<T> _elementEqComparer;

		public IEqualityComparer<T> elementEqComparer
		{
			get { return _elementEqComparer; }
			set { _elementEqComparer = value; }
		}
		
		public Eq(
			IEqualityComparer<T> elementEqComparer
			)
		{
			this._elementEqComparer = elementEqComparer;
		}



		public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
		{

			if (x.Count() != y.Count())
			{
				return false;

			}

			for (int i = 0; i < x.Count(); i++)
			{
				if (!elementEqComparer.Equals(x.ElementAt(i), y.ElementAt(i)))
				{
					return false;

				}

			}
			return true;

			throw new NotImplementedException();
		}

		public int GetHashCode(IEnumerable<T> obj)
		{
			return 0;
			throw new NotImplementedException();
		}
	}
}
