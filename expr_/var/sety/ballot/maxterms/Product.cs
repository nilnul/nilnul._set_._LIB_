using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterms
{

	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		pos
	///		product
	///		prod
	///		product of sums
	internal class IProduct
	{
	}
	public class Product<T>
		:
		nilnul.obj.Box_ofIn<IEnumerable<Maxterm<T>>>

	{
		public Product(in IEnumerable<Maxterm<T>> val) : base(val)
		{
		}

		public Product(IEnumerable<Maxterm<T>> x) : base(x)
		{
		}

		/// <summary>
		/// vs:
		///		<see cref="minterms.Sop{T}"/>
		/// </summary>
		/// <param name="var"></param>
		/// <returns></returns>
		public static Product<T> Of(Var<T> var)
		{
			return new Product<T>(
				new[] {
					new Maxterm<T>(
						new Ballot<T>() {
							[var]=true
						}
					)
				}
			);
		}
	}


}
