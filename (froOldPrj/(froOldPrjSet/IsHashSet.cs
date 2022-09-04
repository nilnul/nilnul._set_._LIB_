using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.finite
{
	public partial class IsHashSet
	{
		//static void Main(string[] args)
		//{
		//    Console.WriteLine(
		//    Check(new HashSet<int>()));
		//    Console.WriteLine(
		//    Check("")	
		//        );
		//    Console.WriteLine(
				
		//        Check(new List<string>())
		//        );
		//    System.Diagnostics.Debug.Write("==============------------");
			
		//}
		public static bool Check(object o) {

			if (o.GetType().IsGenericType)
			{
				return o.GetType().GetGenericTypeDefinition()==typeof(HashSet<object>).GetGenericTypeDefinition();
				
			}

			return false;
		
		
		}

		public static bool Is(Type t) {

			if (t.IsGenericType)
			{
				return t.GetGenericTypeDefinition() == typeof(HashSet<object>).GetGenericTypeDefinition();

			}
			return false;

		
		
		}
	}
}
