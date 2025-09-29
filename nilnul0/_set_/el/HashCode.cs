using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._set_.el
{
	/// <summary>
	/// hashCode is in theory for storing data. for data at the creation time, or at a retrieve time of the same stored content.
	/// </summary>
	/// <remarks>
	/// Note: el in set is mutable. It's important to keep the id (the reference) unchanged as the hashCode, not the content.
	/// </remarks>
	internal class HashCodeX
	{
		/*
If you're going to hash items they need to have some kind of identity so they can be compared.

If that changes, it is not a valid identity method. It really should be readonly, and only set in the constructor.

If your data model says that you can have two objects with the same content but they can't be equal, you should use a surrogate id, not hash the contents. for example, the reference as the id;

If they are mutable types, you should assign a surrogate ID (i.e. one that is introduced externally, like an increasing counter id or using the object's hashcode) that never changes for the given object.
		So for reference as the id, also the hashcode, the hashcode shall not change; and it's calculated on creation from not the internal fields, but from outside assigned number.
		 
		 */

		/*
		 http://blogs.msdn.com/b/ericlippert/archive/2011/02/28/guidelines-and-rules-for-gethashcode.aspx

		"Rule: the integer returned by GetHashCode must never change while the object is contained in a data structure that depends on the hash code remaining stable"

"Guideline: the integer returned by GetHashCode should never change if it's a reference type that is in a set to determines its identity by its reference"

I could change this trivialy to public int GetHashCode() { return 0 } and the member in a set can still mutate.




		http://msdn.microsoft.com/en-us/library/system.object.gethashcode.aspx

"the default implementation of this method must not be used as a unique object identifier for hashing purposes."


		http://msdn.microsoft.com/en-us/library/system.valuetype.gethashcode.aspx

If you call the derived type's GetHashCode method, the return value is not likely to be suitable for use as a key in a hash table.".		 */
		static void Main(string[] args)
		{
				//HashCode.
				/// InternalGetHashCode is mapped to an ObjectNative::GetHashCode
				///
				/*
	Until now, the default GetHashCode implementation for object is unrelated to the object itself and should be unique for each object. And here's the code:

inline DWORD GetNewHashCode()
    {
        LIMITED_METHOD_CONTRACT;
        // Every thread has its own generator for hash codes so that we won't get into a situation
        // where two threads consistently give out the same hash codes.
        // Choice of multiplier guarantees period of 2**32 - see Knuth Vol 2 p16 (3.2.1.2 Theorem A).
        DWORD multiplier = GetThreadId()*4 + 5;
        m_dwHashCodeSeed = m_dwHashCodeSeed*multiplier + 1;
        return m_dwHashCodeSeed;
    }
web.archive.org/web/20100826100454/http://www.koders.com/cpp/fid187B41425FAF5DEC8C7921012C309DC6534FE487.aspx
				
				 
ConditionalWeakTable<TKey,TValue>
				
ObjectIDGenerator
RuntimeHelpers.GetHashCode
				:Serves as a hash function for a particular object, and is suitable for use in algorithms and data structures that use hash codes, such as a hash table.


				 */
		}
	}
}
