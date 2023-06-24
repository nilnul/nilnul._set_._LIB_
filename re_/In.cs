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
	///		subset
	///		sub
	///		inside
	///			implies an improper(equiv) or proper subset, and correspondingly, in may means: propersubset;
	///		in
	///			when in is used for <see cref="_has_.HasI{T}"/>, there is no ambiguity about proper or improper;
	///				for bound that has borders, to tell whether a member is at the border is the responsibility of the bound (a close or open bound), not the relationship;
	///		
	public interface InI
	{
	}
}
