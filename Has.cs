using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{
	/// <summary>
	/// we treat <see cref="Has"/> as not the intrinsic part of <see cref="nilnul.SetI"/>, but as an extension: for a finite collection of elements, we can always tell whether one element is in it or not.
	/// To treat this as an extension, we can later extend the definition of Has part(not including the definition of the set itself, ie, <see cref="_has.OfEl"/>), allowing us to base discrete set and continuum set and beyond on the <see cref="ISet"/>. Of course, we can later shorten nilnul.set._has.OfEl to nilnul.collection
	/// 
	/// </summary>
	/// We can apply the same methodology in nilnul.rel._has.Re to extend relation beyond finite scenario, and still keep the extension on the basis of nilnul.rel.
	public interface IHas
	{
	}
	public interface HasI<T>
		:IHas
		,
		_has_.HasI<T>
	{

	}
}
