using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.str.duo_.sameLen.of_.bit
{
	public class InnerProduct
	{
		static public bool _Multi_innerProduct_sameSize(IEnumerable<bool> row, IEnumerable<bool> _col_sameLen)
		{
			bool r = false;

			for (int i = 0; i < row.Count(); i++)
			{
				r = r || row.ElementAt(i) && _col_sameLen.ElementAt(i);

			}
			return r;


			throw new NotImplementedException();
		}

	}
}
