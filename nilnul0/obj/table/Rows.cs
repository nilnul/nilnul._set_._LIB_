using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace nilnul.obj.table
{
	public class Rows
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="table"></param>
		/// <returns></returns>
		public static IEnumerable<DataRow> ToSeq(DataTable table) {
			return table.Rows.AsQueryable().OfType<System.Data.DataRow>();

		} 


		public static DataRow[] ToArr(DataTable table) {
			return table.Select();

		} 


	}


}
