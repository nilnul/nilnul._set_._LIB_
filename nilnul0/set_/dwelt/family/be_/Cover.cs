using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set_.dwelt.family.be_
{
	/// <summary>
	/// the union of this family is equal to boxed 
	/// </summary>
	class Cover<T> : nilnul.obj.Box1<nilnul.obj.SetI2<T>>
	{
		public Cover(nilnul.obj.SetI2<T> val) : base(val)
		{
		}
	}
}
