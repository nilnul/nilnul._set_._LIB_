using nilnul.set.expr_.var.sety.ballot.maxterm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.expr_.var.sety.ballot.maxterms.coefeds
{

	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		
	internal class IProduct
	{
	}
	public class Product<T>
		:
		nilnul.obj.Box_ofIn<IEnumerable<Coefed<T>>>

	{
		public Product(in IEnumerable<Coefed<T>> val) : base(val)
		{
		}

		public Product(IEnumerable<Coefed<T>> x) : base(x)
		{
		}

		/// <see cref="minterm.coefeds.Sum{T}"/>, where we lack the omega constant, and we cannot do this;
		/// <summary>
		/// </summary>
		/// <param name="var"></param>
		/// <returns></returns>
		public static Product<T> Of(Var<T> var)
		{
			return new Product<T>(
				new[] {
					new Coefed<T>(
						new Maxterm<T>(
							new Ballot<T>() {
								[var]=true
							}
						)
					)
				}
			);
		}
	}


}
