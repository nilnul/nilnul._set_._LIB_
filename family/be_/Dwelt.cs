using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.be_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///		
	public class Dwelt<T> : nilnul.set.family.BeI<T>
	{
		public bool be(Family<T> obj)
		{
			return obj.Any();
		}

		static public Dwelt<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Dwelt<T>>.Instance;
			}
		}

	}
}
