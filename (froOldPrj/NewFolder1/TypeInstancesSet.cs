using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.collection.set
{
	public class TypeInstancesSet:SetI
	{
		private Type _type;
		public Type type {
			get {
				return _type;
			}
			set {
				this._type = value;
			}
			
		}
		public TypeInstancesSet(Type type) {
			this.type = type;

		}
		public  bool hasElement(object element)
		{
			return element.GetType() == this.type;
		}
	}
}
