using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection
{
	/// <summary>
	/// 
	/// </summary>
	 public partial class IndexSet
	{
		private uint _length;

		 /// <summary>
		 /// exclusive.
		 /// </summary>
		public uint length
		{
			get { return _length; }
			set { _length = value; }
		}

		public IndexSet(uint length)
		{
			this.length = length;
		}


		public IndexSet(int length)
		{
			this.length = (uint)length;
		}



		static public IndexSet GetIndexSet<T>(IEnumerable<T> enumerables) {
			return new IndexSet(enumerables.Count());
		
		}

		 public uint this[uint x]{
			get{
				if (x<length)
				{
					return x;
					
				}
				throw new Exception();
			}
		 }



		 public HashSet<uint> toHashSet() {
			var r = new HashSet<uint>();
			for (uint i = 0; i < length; i++)
			{
				r.Add(i);
				
			}
			return r;
			
		}
					
		
	}

	 static public class IndexSetX { 
	 
		
	 }
}
