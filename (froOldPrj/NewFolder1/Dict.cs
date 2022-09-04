using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection
{

	/// <summary>
	/// adapt dictionry such that:
	/// 
	/// if no key is found return null instead of throw new exception
	/// when setting a key to null, delete the key.
	/// key cannot be null.
	/// </summary>
	/// <typeparam name="Key"></typeparam>
	/// <typeparam name="Value"></typeparam>
	public partial class Dict<Key,Value>:Dictionary<Key,Value>
	{
		


		
					
	}
}
