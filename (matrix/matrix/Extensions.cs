using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.bit;
using nilnul.collection.matrix;

namespace nilnul.matrix
{
	/// <summary>
	/// This will regard two-dimensional arrays as Matrix and define matrix computation.
	/// The mothods we defined on our matrix class is not applicable on these arrays for they are built in CLR types; however we convert or box them as matrix and compute, then unbox back.
	/// 
	/// ToString, operators can be added to the wrapper, though no constraints are added as generally a new type is defined upon.
	/// </summary>
	static public  class Extensions
	{
		static public _matrix.Dimension Dimension<T>(T[,] m) {

			if (m==null)
			{
				return nilnul._matrix.Dimension.Zero;
				
			}
			return new _matrix.Dimension(m.GetLongLength(0), m.GetLongLength(1));

		
		}


		static public bool Eq<T>(this T[,] a, T[,] b)
		//where T:IEquatable<T>
		{
			return Eq2(a,b,EqualityComparer<T>.Default.Equals);
			

		}

		static public void SwapTwoRows<T>(T[,] matrix, int i,int j) {
			var tempRow = new T[matrix.GetLength(1)];
			T temp;
			for (int k = 0; k < matrix.GetLength(1); k++)
			{
				temp=matrix[i, k];
				matrix[i, k] =matrix[j, k] ;

				matrix[j, k] = temp;

			}


		}

	

		static public bool Eq<T>(this T[,] a, T[,] b, IEqualityComparer<T> comparer)
		//where T:IEquatable<T>
		{
			nilnul.bit.Assert.Eq(Dimension(a), Dimension(b));

			for (long i = 0; i < a.GetLongLength(0); i++)
			{
				for (long j = 0; j < a.GetLongLength(1); j++)
				{
					

					if (
						!comparer.Equals(
							a[i, j],b[i, j]
						) 
					)
					{
						return false;


					}

				}

			}
			return true;



		}
		static public bool Eq2<T>(this T[,] a, T[,] b, IEqualityComparer<T> comparer)
		{
			return Eq2(a, b, comparer.Equals);
		}


		static public bool Eq<T>(this T[,] a, T[,] b, Func<T,T,bool> comparer)
		//where T:IEquatable<T>
		{
			nilnul.bit.Assert.Eq(Dimension(a), Dimension(b));

			for (long i = 0; i < a.GetLongLength(0); i++)
			{
				for (long j = 0; j < a.GetLongLength(1); j++)
				{


					if (
						!comparer(
							a[i, j], b[i, j]
						)
					)
					{
						return false;


					}

				}

			}
			return true;



		}

	



		static public bool Eq2<T>(this T[,] a, T[,] b, Func<T, T, bool> comparer)
		//where T:IEquatable<T>
		{
			if (a.GetLength(0) !=b.GetLength(0) || a.GetLength(1) !=b.GetLength(1))
			{
				return false;
				
			}

			for (long i = 0; i < a.GetLongLength(0); i++)
			{
				for (long j = 0; j < a.GetLongLength(1); j++)
				{


					if (
						!comparer(
							a[i, j], b[i, j]
						)
					)
					{
						return false;


					}

				}

			}
			return true;



		}




		static public bool Eq<T>(this Matrix<T> a, Matrix<T> b)
		{

			return Eq(a.components, b.components);



		}

		/// <summary>
		/// Fill the matrix with the same element.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="element"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <returns></returns>
		static public T[,] GenerateMatrix<T>(this T element, int width, int height) { 
			T[,] r=new T[width,height];

			for (int i = 0; i < r.GetLength(0);i++ )
			{
				for (int j = 0; j < r.GetLength(1);j++ )
				{
					r[i, j] = element;
				}
			}
			return r;

		}

		/// <summary>
		/// Get the index set of the rows or columns
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix"></param>
		/// <param name="dimension"></param>
		/// <returns></returns>
		static public HashSet<int> GetIndex<T>(this T[,] matrix,int dimension) {
			if (dimension > 1 || dimension < 0) {
				throw new Exception();
			}

			HashSet<int> r = new HashSet<int>();
			for (int i = 0; i < matrix.GetLength(dimension);i++ )
			{
				r.Add(i);

			}
			return r;
		}


		/// <summary>
		/// By the first dimension.{{a,b,c}, {d,e,f}}: take out {a,b,c} or ....
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix"></param>
		/// <param name="?"></param>
		/// <returns></returns>
		static public IEnumerable<T> Row<T>(this T[,] matrix,int n) {
			if(n<0 || n>=matrix.GetLength(0)){
				throw new Exception();
			}
			for(int j=0;j<matrix.GetLength(1);j++){
				yield return matrix[n, j];
			}
			

		}

		static public IEnumerable<T> Column<T>(this T[,] matrix, int n)
			
		{
			if (n < 0 || n >= matrix.GetLength(1))
			{
				

				throw new Exception();
			}
			for (int j = 0; j < matrix.GetLength(0); j++)
			{
				yield return matrix[j, n];
			}


		}

		static public IEnumerable<T[]> Rows<T>(this T[,] matrix) {
			for (int i = 0; i < matrix.GetLength(0);i++ )
			{
				yield return matrix.Row(i).ToArray();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix"></param>
		/// <returns></returns>
		[Obsolete("use Columns")]
		static public IEnumerable<T[]> Cols<T>(this T[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(1); i++)
			{
				yield return matrix.Column(i).ToArray();
			}
		}

		static public IEnumerable<T[]> Columns<T>(this T[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(1); i++)
			{
				yield return matrix.Column(i).ToArray();
			}
		}


		static public T[] ToVector<T>(this T[,] matrix) {

			

			if (matrix.GetLength(0) == 1)
			{
				T[] r = new T[matrix.GetLength(1)];
				for (int i = 0; i < r.Length; i++)
				{
					r[i] = matrix[0, i];
				}
				return r;
			}
			else if (matrix.GetLength(1) == 1)
			{
				return matrix.Transpose().ToVector();
			}
			else {
				throw new Exception();
			}
		}


		/// <summary>
		/// Join horiztonally placed together like two doors.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix1"></param>
		/// <param name="matrix2"></param>
		/// <returns></returns>
		static public T[,] Merge<T>(this T[,] matrix1, T[,] matrix2) {
			if(matrix1.GetLength(0) != matrix2.GetLength(0)){
				throw new Exception();
			}

			T[,] r = new T[matrix1.GetLength(0), matrix1.GetLength(1) + matrix2.GetLength(1)];

			for (int i = 0; i < r.GetLength(0);i++ )
			{
				for (int j = 0; j < r.GetLength(1);j++ )
				{
					
						r[i, j] = j < matrix1.GetLength(1) ? matrix1[i, j] : matrix2[i, j - matrix1.GetLength(1)];
					
				}
			}
			return r;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="matrix1"></param>
		/// <param name="matrix2"></param>
		/// <returns></returns>
		static public T[,] Join<T>(this T[,] matrix1, T[,] matrix2) {
			if(matrix1.GetLength(0) != matrix2.GetLength(0)){
				throw new Exception();
			}

			T[,] r = new T[matrix1.GetLength(0), matrix1.GetLength(1) + matrix2.GetLength(1)];

			for (int i = 0; i < r.GetLength(0);i++ )
			{
				for (int j = 0; j < r.GetLength(1);j++ )
				{
					
						r[i, j] = j < matrix1.GetLength(1) ? matrix1[i, j] : matrix2[i, j - matrix1.GetLength(1)];
					
				}
			}
			return r;
		}



		static public T[,] Union<T>(this T[,] matrix1, T[,] matrix2)
		{
			return matrix1.Transpose().Join(matrix2.Transpose()).Transpose();

		}

		static public T[,] Delete<T>(this T[,] parent, HashSet<int> rows2delete, HashSet<int> columns2delete) {
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
	
		static public T[,] Delete<T>(this T[,] parent, IEnumerable<int> rows2delete, IEnumerable<int> columns2delete) {

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


		static public T[,] SubmatrixLastColumns<T>(this T[,] parent,int howMany) { 
			if(howMany>parent.GetLength(1) ||
				howMany<0
				){
				throw new Exception();
			}

			HashSet<int> lastColumnsIndex=new HashSet<int>();

			for(int i=0;i<howMany;i++){
				lastColumnsIndex.Add(parent.GetLength(1)-howMany+i);
			}

			return Submatrix(
				parent,
				parent.GetIndex(0),
				lastColumnsIndex
				
			);
		}

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


		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <returns></returns>
		public static double[,] Adjoint(this double[,] matrix)
		{

			//it has to be square

			int n = matrix.GetLength(0);

			if (matrix.GetLength(1) != n)
			{
				throw new Exception("The matrix has to be square.");
			}


			double[,] r = new double[matrix.GetLength(1), matrix.GetLength(0)];

			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (int j = 0; j < r.GetLength(1); j++)
				{
					r[i, j] = matrix.AlgebraicCofactor(j, i);
				}
			}
			return r;

		}



		public static double[,] Cofactor(this double[,] matrix, int m, int n)
		{
			double[,] r = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
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

		public static double AlgebraicCofactor(this double[,] squareMatrix, int m, int n)
		{

			//if (!squareMatrix.IsSquare()) {
			//    throw new Exception("The matrix must be square.");
			//}
			if ((m % 2) == (n % 2))
			{
				return Cofactor(squareMatrix, m, n).Determinant();
			}
			else
			{
				return -Cofactor(squareMatrix, m, n).Determinant();

			}


		}

		public static double[,] Inverse(this double[,] matrix)
		{
			if (!IsSquare(matrix))
			{
				throw new Exception("The matrix is not square.");
			}
			double determ = matrix.Determinant();

			if (determ == 0)
			{
				throw new Exception("The determinant of the matrix is 0 so it's not inversible.");
			}

			if (matrix.GetLength(0) == 1)
			{
				return new double[,] { { 1 / matrix[0, 0] } };

			}
			else
			{

				return (1.0 / determ).Multiply(matrix.Adjoint());

			}




		}

		/// <summary>
		/// A real number times a Matrix
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="a"></param>
		/// <returns></returns>
		public static double[,] Multiply(this double[,] matrix, double a)
		{

			double[,] r = new double[matrix.GetLength(0), matrix.GetLength(1)];

			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (int j = 0; j < r.GetLength(1); j++)
				{
					r[i, j] = matrix[i, j] * a;
				}

			}
			return r;

		}

		/// <summary>
		/// A real number times a matrix
		/// </summary>
		/// <param name="a"></param>
		/// <param name="matrix"></param>
		/// <returns></returns>
		public static double[,] Multiply(this double a, double[,] matrix)
		{

			double[,] r = new double[matrix.GetLength(0), matrix.GetLength(1)];

			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (int j = 0; j < r.GetLength(1); j++)
				{
					r[i, j] = matrix[i, j] * a;
				}

			}
			return r;

		}


		public static bool IsSquare(this double[,] matrix)
		{
			return matrix.GetLength(0) == matrix.GetLength(1);
		}

		public static double Determinant(this double[,] squareMatrix)
		{

			if (squareMatrix.GetLength(0) != squareMatrix.GetLength(1))
			{
				throw new Exception("The matrix must be square.");
			}

			if (squareMatrix.GetLength(0) == 0)
			{
				throw new Exception("The square matrix must be 1 or more in width.");
			}

			//suppose it's one in length.
			if (squareMatrix.GetLength(0) == 1)
			{

				return squareMatrix[0, 0];
			}
			else
			{
				double r = 0;
				for (int i = 0; i < squareMatrix.GetLength(0); i++)
				{
					r += squareMatrix[0, i] * squareMatrix.AlgebraicCofactor(0, i);
				}
				return r;
			}

		}

		static public T[,] Clone<T>(T[,] x) {
			var rows = x.GetLength(0);
			var cols = x.GetLength(1);
			var r = new T[rows, cols];

			for (int i = 0; i <rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{

					r[i, j] = x[i, j];
				}
				
			}
			return r;

		}

		static public T[,] ToMatrix<T>(this T[] vector) {
			T[,] r = new T[1, vector.Length];
			for (int i = 0; i < r.GetLength(1);i++ )
			{
				r[0, i] = vector[i];
			}
			return r;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="vector"></param>
		/// <returns></returns>
		static public T[,] ToMatrixVertical<T>(this T[] vector)
		{
			return vector.ToMatrix().Transpose();
		}




		static public double[,] Multiply(this double[,] a, double[,] b)
			
			
		{
			if (a.GetLength(1) != b.GetLength(0))
			{
				throw new Exception("arg[0].GetLength(1)!=arg[1].GetLength(0).");
			}

			int n = a.GetLength(1);

			double[,] r = new double[a.GetLength(0), b.GetLength(1)];
			double c;

			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (uint j = 0; j < r.GetLength(1); j++)
				{
					c = 0;
					for (int k = 0; k < a.GetLength(1); k++)
					{
						c += a[i, k] * b[k, j];
					}
					r[i, j] = c;

				}
			}
			return r;
		}



		static public T[,] Transpose<T>(this T[,] matrix) {
			T[,] r = new T[matrix.GetLength(1), matrix.GetLength(0)];
			for (int i = 0; i < r.GetLength(0);i++ )
			{
				for (int j = 0; j < r.GetLength(1); j++) {
					r[i, j] = matrix[j, i];
				}
			}
			return r;
		}

		static public Matrix<T> Transpose<T>(this Matrix<T> matix)
		{

			return new Matrix<T>(Transpose(matix.components));

		}



		static public string toString<T>(this T[,] matrix)
		{
			string seperator = ",";
			string r = "";
			r += "{";
			for (uint i = 0; i < matrix.GetLength(0); i++)
			{
				r += "{";

				for (uint j = 0; j < matrix.GetLength(1); j++)
				{
					r += matrix[i, j];
					r += ",";
				}
				r = r.Remove(r.Length - seperator.Length);
				r += "}";
				r += ",";
			}
			r = r.Remove(r.Length - seperator.Length);
			r += "}";
			return r;

		}


		static public string ToString_<T>(this T[,] matrix)
		{
			string seperator = ",";

			string r = "";
			r += "{";
			uint i;
			for (i = 0; i < matrix.GetLength(0); i++)
			{
				r += "{";

				uint j;
				for (j = 0; j < matrix.GetLength(1); j++)
				{
					r += matrix[i, j];
					r += ",";
				}
				if (j>0)
				{
					r = r.Substring(0, r.Length - seperator.Length);

				}
				r += "}";
				r += ",";
			}

			if (i>0)
			{
				r = r.Substring(0, r.Length - seperator.Length);
			
			}
		
			r += "}";
			return r;

		}



	}//class



}
