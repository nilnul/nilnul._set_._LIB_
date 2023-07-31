using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterm.coefeds_.isovars_.unlike
{

	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		pos
	///		product
	///		prod
	///		product of sums
	///		intersect
	internal class IProduct
	{
	}
	public class Product<T>
		:
		nilnul.obj.Box_ofIn<Unlike<T>>

	{
		public Unlike<T> coefeds { get { return boxed; } }	

		public Product(in Unlike<T> val) : base(val)
		{
		}

		public Product(Unlike<T> x) : base(x)
		{
		}

		/// <summary>
		/// prod( ), this is the omega.
		/// </summary>
		public Product():this(new Unlike<T>())
		{
				
		}
		public static Product<T> Of(IEnumerable< Coefed<T>> coefeds)
		{
			return new Product<T>(
				new Unlike<T>(coefeds)
			);
		}
		public static Product<T> Of(Coefed<T>[] coefeds)
		{
			return new Product<T>(
				new Unlike<T>(coefeds)
			);
		}

		public static Product<T> Of(Coefed<T> coefed)
		{
			return Of(new[] { coefed });
		}
		public static Product<T> Of(HashSet<T> ts)
		{
			return Of( new Coefed<T>(ts));

		}




		public static Product<T> Of(Maxterm<T> maxterm)
		{
			return Of( new Coefed<T>(maxterm) );
		}
		public static Product<T> Of(Var<T> var)
		{
			return Of(  Maxterm<T>.Of(var));
		}

	}


}
