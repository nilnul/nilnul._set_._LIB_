using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set._family_.elEq_
{
	public class EqDefaulted<T, TEq>
		:
		_family_.ElEqA<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public EqDefaulted() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}
	}
}
