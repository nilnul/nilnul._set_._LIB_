using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;

namespace nilnul.matrix.op_
{
	/// <summary>
	 
	/// </summary>
	static public   class _SelX
	{
		 
   
  

		static public T[,] Submatrix<T>(this T[,] parent,HashSet<int> selectedRows, HashSet<int> selectedColumns) {

			if(
				selectedRows.Any(
					x => (
						x>=parent.GetLength(0))
						||
						x<0
				)
				||
				selectedColumns.Any(
					x => (
						x>=parent.GetLength(1))
						||
						x<0
				)
			){
				throw new Exception();
			}

			T[,] r = new T[selectedRows.Count, selectedColumns.Count];

			int m = 0;
		//	int n = 0;

			for(int i=0; i<parent.GetLength(0); i++){
				if (selectedRows.Contains(i))
				{
					int n = 0;
					for (int j=0;j<parent.GetLength(1);j++) {
						if (selectedColumns.Contains(j))
						{
							r[m, n] = parent[i, j];

							n++;
						}
						
					}
					m++;
				}
				
				
			}
			return r;
		}//Submatrix

  


	}//class



}
