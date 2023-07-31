using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;

namespace nilnul.matrix.op_
{
	/// <summary>
	/// This will regard two-dimensional arrays as Matrix and define matrix computation.
	/// The mothods we defined on our matrix class is not applicable on these arrays for they are built in CLR types; however we convert or box them as matrix and compute, then unbox back.
	/// 
	/// ToString, operators can be added to the wrapper, though no constraints are added as generally a new type is defined upon.
	/// </summary>
	static public   class _DelX
	{
		

		static public T[,] Delete<T>(this T[,] parent, HashSet<int> rows2delete, HashSet<int> columns2delete) {
			HashSet<int> selectedRows = parent.GetIndex(0);
			selectedRows.ExceptWith(rows2delete);

			HashSet<int> selectedColumns = parent.GetIndex(1);
			selectedColumns.ExceptWith(columns2delete);

		
			return _SelX.Submatrix(
				parent,
				selectedRows,
				selectedColumns
			);
		}
	
		static public T[,] Delete<T>(this T[,] parent, IEnumerable<int> rows2delete, IEnumerable<int> columns2delete) {

			HashSet<int> selectedRows = parent.GetIndex(0);
			selectedRows.ExceptWith(rows2delete);

			HashSet<int> selectedColumns = parent.GetIndex(1);
			selectedColumns.ExceptWith(columns2delete);

		
			return _SelX.Submatrix(
				parent,
				selectedRows,
				selectedColumns
			);
		}

		static public T[,] Delete<T>(this T[,] parent, int rows2delete, int columns2delete)
		{
			return Delete(parent, new HashSet<int>(new[] { rows2delete }), new HashSet<int>(new []{columns2delete}));
		}


		public static T[,] Deltete_literally<T>(this T[,] matrix, int m, int n)
		{
			var r = new T[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
			for (int i = 0; i < r.GetLength(0); i++)
			{
				if (i < m)
				{
					for (uint j = 0; j < r.GetLength(1); j++)
					{

						if (j < n)
						{
							r[i, j] = matrix[i, j];
						}
						else
						{
							r[i, j] = matrix[i, j + 1];
						}

					}
				}
				else
				{
					for (int j = 0; j < r.GetLength(1); j++)
					{

						if (j < n)
						{
							r[i, j] = matrix[i + 1, j];
						}
						else
						{
							r[i, j] = matrix[i + 1, j + 1];
						}

					}


				}

			}
			return r;

		}//Cofactor





	}//class



}
