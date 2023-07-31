using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.re_
{
	/// <summary>
	/// one set is inside or equals to another
	/// </summary>
	/// <remarks>
	/// nomenclature:
	///		some use "in" as "a member " is in "a set"
	///		but we think:
	///			1) it's natural to say a basin is in a nother basin. so is to say a set is in another set.
	///			2) "in" is the complement to "inc", which means on set is the superset of another set.
	///				2.1) while has means one set contains a member.
	///			3) "has" is more explicit in expressing the meaning of a collection "having" a property/member.
	///				
	/// 
	/// </remarks>
	/// alias:
	///		
	///		inside
	///			as have is to <see cref="set.IHas"/>, meaning: "has" every element of the second set, within is for every element in the first set is in the second.
	///		within
	///		
	///		subset
	///		
	///		
	/// vs:
	///		<see cref="set.el.be_.ElInSet"/>
	public interface ISubset
	{
	}
}
