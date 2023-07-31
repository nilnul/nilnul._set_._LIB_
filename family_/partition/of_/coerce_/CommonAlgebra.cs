using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family_.partition.of_.coerce_
{
	/// <summary>
	/// for joint sets, we can get the <see cref="algebra_.common_.IClosed"/> until it cannot be leaned as a nonempty set.
	/// eg:
	///		{
	///			{a,b}
	///			,
	///			{b,c}
	///		}
	///		,
	///		we get:
	///		{
	///			{b}
	///			,{a,b}
	///			,{a}
	///			,
	///			{b,c}
	///			,
	///			{c}
	///		}
	///		,
	///		thus {{a},{b},{c}} is the generated <see cref="IPartition"/>
	/// </summary>
	/// <remarks>
	/// eg:
	///		{}
	///		,
	///		we get {}, it's still a partition.
	/// </remarks>
	internal class CommonAlgebra
	{
	}
}
