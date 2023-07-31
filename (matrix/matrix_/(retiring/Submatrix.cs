using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;

namespace nilnul.collection.matrix
{
	/// <summary>
	/// This will regard two-dimensional arrays as Matrix and define matrix computation.
	/// The mothods we defined on our matrix class is not applicable on these arrays for they are built in CLR types; however we convert or box them as matrix and compute, then unbox back.
	/// </summary>
	static public partial class SubmatrixX
	{
		static public T[,] Delete<T>(this T[,] parent, int row2delete, int column2delete)
		{
			return Delete(parent,new HashSet<int>(new []{row2delete}),new HashSet<int>(new []{column2delete}));
		}


		static public T[,] Delete<T>(this T[,] parent, HashSet<int> rows2delete, HashSet<int> columns2delete)
		{
			HashSet<int> selectedRows = parent.GetIndex(0);
			selectedRows.ExceptWith(rows2delete);

			HashSet<int> selectedColumns = parent.GetIndex(1);
			selectedColumns.ExceptWith(columns2delete);


			return Submatrix(
				parent,
				selectedRows,
				selectedColumns
			);
		}




		static public T[,] Submatrix<T>(this T[,] parent, HashSet<int> selectedRows, HashSet<int> selectedColumns)
		{

			if (
				selectedRows.Any(
					x => (
						x >= parent.GetLength(0))
						||
						x < 0
				)
				||
				selectedColumns.Any(
					x => (
						x >= parent.GetLength(1))
						||
						x < 0
				)
			)
			{
				throw new Exception();
			}

			T[,] r = new T[selectedRows.Count, selectedColumns.Count];

			int m = 0;
			//	int n = 0;

			for (int i = 0; i < parent.GetLength(0); i++)
			{
				if (selectedRows.Contains(i))
				{
					int n = 0;
					for (int j = 0; j < parent.GetLength(1); j++)
					{
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

	}
	


}
