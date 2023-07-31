using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.vector
{
	public partial class Sum
	{
		static public bool Or(bool[] row) {
			return row.Aggregate(false, (a, c) => a || c);

			throw new NotImplementedException();
		}

		static public bool Or_returnEarly(bool[] row)
		{

			foreach (var item in row)
			{
				if (item)
				{
					return true;
				}
				
			};
			return false;

			throw new NotImplementedException();
		}

	}
}
