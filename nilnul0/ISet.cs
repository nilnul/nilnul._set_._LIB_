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
	[Obsolete(nameof(nilnul.obj.ISet))]
	public interface ISet:nilnul.obj.ISet
	{
	}
	
}
