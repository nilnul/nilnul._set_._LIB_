using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.pargoid_
{
	public interface IDelta:IPargoid { }
	/// <summary>
	///  a family, and the <see cref="set.op_.binary_.IDelta"/>, forms an algebra of one Op. <seealso cref="nilnul.obj.op_.binary.set_.Pargoid"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///		
	public interface IDelta<T> :
		IDelta
	{
	}
}
