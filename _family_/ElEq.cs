using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set._family_
{
	/// <summary>
	/// note MemberEq is the equality of member of the family; elEq is the equality of the member/element of the set, which is in turn the member of family.
	/// element is the smallest unit
	/// <see cref="nameof(nilnul.obj._set_.MemberEqI<typeparamref name="T"/>)"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TEq"></typeparam>
	/// element
	///		is the basis clause used in the recursion definition
	public interface ElEqI<T,TEq>
		where TEq:IEqualityComparer<T>
	{
		TEq elEq { get; }
	}

	public interface ElEqI<T>
		:ElEqI<T,IEqualityComparer<T>>
	{
		
	}

	public abstract class ElEqA<T> :
		nilnul.obj.Box<IEqualityComparer<T>>
		,
		ElEqI<T>
	{
		public ElEqA(IEqualityComparer<T> val) : base(val)
		{
		}

		public IEqualityComparer<T> elEq => boxed;
	}



}
