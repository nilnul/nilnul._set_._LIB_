using nilnul.set.op_.unary_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.op_.binary_.concur_
{
	class ByDeltaDual<T>
		:
		nilnul.obj.Box1<
			op_.unary_.Complement<T>
		>
		
		,
		nilnul.set.op_.BinaryI<T>
	{
		public ByDeltaDual(Complement<T> val) : base(val)
		{
		}


		public obj.SetI2<T> op(obj.SetI2<T> par, obj.SetI2<T> par1)
		{
			return boxed.op( binary_.Delta<T>.Singleton.op(par, par1) );

			//throw new NotImplementedException();
		}
	}
}
