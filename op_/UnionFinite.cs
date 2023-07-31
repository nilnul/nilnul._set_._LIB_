using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set
{
    //this is an operator on a finite collection of sets.
    public partial  class UnionFinite
    {


        static private readonly UnionFinite _Instance = new UnionFinite();
        static public UnionFinite Instance
        {
            get
            {
                return _Instance;
            }
        }
        private UnionFinite()
        {
        }

       
				

    }

    static public class UnionFiniteX {

        static public HashSet<T> Union<T>(this IEnumerable<HashSet<T>> sets) {
            ///take the first element as a set.
            ///
            return sets.Aggregate(
                new HashSet<T>(),
                ((a,c)=>{a.UnionWith(c);return a;})
             )
                ;

        }
    }
}
