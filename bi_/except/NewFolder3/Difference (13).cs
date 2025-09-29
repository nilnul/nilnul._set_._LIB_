using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;

namespace nilnul.collection.set
{
	public class Difference 

	{

		static  private readonly Difference _Instance = new Difference();
		private Difference() { }
		static  public Difference Instance
		{
			get
			{
				return _Instance;
			}
		}


		public  char sign
		{
			get { return '-'; }
		}
	}
}
