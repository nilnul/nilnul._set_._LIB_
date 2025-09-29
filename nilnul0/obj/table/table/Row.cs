using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.table
{
	static public class _RowX
	{
		static public object[] ToArr(DataRow row) {
			return row.ItemArray;
		}
	}
}
