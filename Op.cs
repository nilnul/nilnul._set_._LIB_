using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{
	public interface IOp { }
	/// <summary>
	/// operation on family of sets of type <typeparamref name="T"/>. The eqComparer is the same in each of the sets
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IOp<T>
		:IOp
	{
	}
	public interface IOp<T,TEq>
		:IOp<T>
		where TEq:IEqualityComparer<T>

	{
	}



}
