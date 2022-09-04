using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set.op
{
	public partial class Union<T>:BinaryI<T>
	{

		public bit.op.binary.BinaryI membershipLogic
		{
			get {
				return bit.op.binary.Or.Instance;
				
			}
		}
	}
}
