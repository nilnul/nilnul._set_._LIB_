using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.op
{
	/// <summary>
	/// 
	/// </summary>
	static public partial class SuccessorX
	{
		static public Set Exec(Set set) {
			

			Set singleton=new Set();

			singleton.Add(set);	//note set must be derefenced.


			Set r = new Set(set);

			r.UnionWith(singleton);


			return r;
		
		}

	}
}
