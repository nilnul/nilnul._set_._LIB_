using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set
{
	static public class _PhraseX
	{
		static public string Phrase<T>(HashSet<T> set) {
			return $"{{{string.Join(",",set)}}}";
		}
		static public string Phrase<T>(IEnumerable<T> set, IEqualityComparer<T> equality) {
			return Phrase(new HashSet<T>(set,equality));
		}


	}
}
