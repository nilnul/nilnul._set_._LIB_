using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.linearAlgebra
{



	/// <summary>
	/// extends some methods related to Vector. For one-dimensional array can be regarded as vector, we extend some vector methods to one-dimensional arrays.
	/// Of course we can box one-dimensional array as vector then compute and then unbox.
	/// </summary>
	static public partial class Vector_Extension {

		public static double[] Plus(this double[] a,double[] b){
			double[] c=new double[a.Length];
			for(uint i=0;i<a.Length;i++){
				c[i]=a[i]+b[i];
			}
			
			return c;
		}


		//public static T[] Plus<T>(this T[] a, T[] b)
			
		//{
		//    T[] c = new T[a.Length];
		//    for (uint i = 0; i < a.Length; i++)
		//    {
		//        c[i] = a[i] + b[i];
		//    }

		//    return c;
		//}


		public static double[] Minus(this double[] a, double[] b){
			double[] c=new double[a.Length];
			for(uint i=0;i<a.Length;i++){
				c[i]=a[i]-b[i];
			}
			return c;


		}


		/// <summary>
		/// a horizontal vector times a matrix.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double[] Multiply(this double[] a,double[,] b) { 
			if(a.Length!=b.GetLength(1)){
				throw new Exception("Arguments[0].length!=arguments[1].length.");
			}
			double[] c = new double[b.GetLength(1)];//every element has been initialized to 0.

			
			for (uint j = 0; j < c.Length;j++ )
			{
				
				for (uint i = 0; i < b.GetLength(0);i++ )
				{
					c[j] += a[i] * b[i, j];
				}
			}
			return c;

		}

		/// <summary>
		/// Inner Product.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static double Multiply(this double[] a, double[] b)
		{
			if (a.Length != b.Length)
			{
				throw new Exception("Arguments[0].length!=arguments[1].length.");
			}

			

			double r = 0;
			for (uint i = 0; i < a.GetLength(0); i++)
			{
				r += (a[i] * b[i]);

				
			}
			return r;

		}

	
		


		



		 static public string toString(this uint[] vector)
		{
			string seperator = ",";
			string r = "";
			r += "{";
			for (uint i = 0; i < vector.Length; i++)
			{
				r += vector[i];
				r += seperator;
			}

			r = r.Remove(r.Length - seperator.Length);
			r += "}";
			return r;
		}
		

	}


	
}
