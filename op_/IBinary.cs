using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.op_
{
	public  interface IBinary
		:nilnul.obj.op_.IBinary<nilnul.obj.ISet>
		,
		set.IOp
	{
	}
	public interface IBinary<T> : IBinary,set.IOp<T>
		,
		nilnul.obj.op_.IBinary<nilnul.obj.ISet<T> >
	{ }

}
