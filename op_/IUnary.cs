using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.op_
{
	public  interface IUnary
		:nilnul.obj.op_.IUnary<nilnul.obj.ISet>
		,
		nilnul.set.IOp
	{
	}
	public interface IUnary<T> : IUnary
		,
		nilnul.obj.op_.IUnary<nilnul.obj.ISet<T> >
	{ }
}
