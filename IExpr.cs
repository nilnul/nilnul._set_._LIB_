using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{
	public interface IExpr
		:
		nilnul.obj.IExpr<nilnul.ISet>
	{
	}

	public interface IExpr<T>
		:
		nilnul.obj.IExpr<nilnul.ISet<T>>
	{
	}

	public interface IExpr<T,TEq>
		:
		nilnul.obj.IExpr<nilnul.ISet<T,TEq>>

		where TEq:IEqualityComparer<T>,new()

	{
	}

	public interface IExpr<T,TEq,TOmega>
		:
		nilnul.obj.IExpr<nilnul.ISet<T,TEq,TOmega>>

		where TEq:IEqualityComparer<T>,new()
		where TOmega:nilnul.ISet<T,TEq>,new()

	{
	}




}
