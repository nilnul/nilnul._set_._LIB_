using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	/// <summary>
	/// a finite collection of elements
	/// </summary>
	/// for nonfinite/infinite collection, see extensions at <see cref="nilnul.set._has.Has"/>
	///
	//[Obsolete(nameof(nilnul.obj.ISet))]
	public interface ISet:nilnul.obj.ISet
	{
	}
	public interface ISet<T>:ISet 
	{
	}

	public interface ISet<T, TEq> : ISet<T>
		where TEq : IEqualityComparer<T>, new()
	{ }

	public interface ISet<T, TEq,TOmega> : ISet<T,TEq>
		where TEq : IEqualityComparer<T>, new()
		where TOmega:ISet<T, TEq>,new()
	{ }


	



	
}
