using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set
{
	[Obsolete()]
	public  class EmptySet<T>:SetI<T>
	{

		static private readonly EmptySet<T> _Instance = new EmptySet<T>();
		static public EmptySet<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		private EmptySet()
		{
		}
				
		

		public bool contains(T a)
		{
			return false;
		}
	}
}
