using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.abgebra_.pargoid_
{
	/// <summary>
	/// the family can be empty.
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///		
	public interface IConcur<T> :
		abgebra_.IPargoid
	{
	}
}
	/// ???the universal set is needed and implied as we need to have the <see cref="set.op_.binary_.IConcur{TEl}"/> which need a universal set.
	/// we can simply take the union of all family members as the universal set; but we need to ensure that the union of all family members are the same as that of the <see cref="set.op_.binary_.IConcur{TEl}"/>
