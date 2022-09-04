using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set
{
	/// <summary>
	/// all the instances of T
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Literal<T>:SetI<T>
	{
		public bool contains(T a)
		{
			return true;
		}
	}
}
