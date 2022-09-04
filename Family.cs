using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.set
{
	/// <summary>
	/// obj comprises set; set comprises family.
	/// members are sets; the member of member is called element
	/// </summary>
	public interface IFamily {

	}
	/// <summary>
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public class Family<TEl> : 
		HashSet<HashSet<TEl>>
		,
		
		nilnul.obj.SetI1<nilnul.obj.SetI1<TEl>>

		,_family_.ElEqI<TEl>
	{
		private IEqualityComparer<TEl> _elEq;

		[Obsolete(nameof(elEq))]
		public IEqualityComparer<TEl> objEq
		{
			get { return _elEq; }
			//set { _objEq = value; }
		}

		public Family(
			IEqualityComparer<TEl> elEq1

		):base(
			new nilnul.obj.set.Eq<TEl>(elEq1) //as IEqualityComparer<HashSet<T>>
		)
		{
			_elEq = elEq1;
		}

		//public Family(HashSet<HashSet<TEl>> family):
		//	this
		//{

		//}

		public Family(IEqualityComparer<TEl> elEq2
			,IEnumerable<
				IEnumerable<TEl>
			> sets

		):base(
			sets.Select(set=> new HashSet<TEl>(set, elEq2)),
			new nilnul.obj.set.Eq<TEl>(elEq2) //as IEqualityComparer<HashSet<T>>
			
		)
		{
			_elEq = elEq2;
		
		}

		public Family(IEqualityComparer<TEl> objEq
			,IEnumerable<
				HashSet<TEl>
			> sets

		):this(
			objEq,
			(IEnumerable<
				IEnumerable<TEl>
			>)sets
			
		)
		{
		
		}

		public Family(HashSet<HashSet<object>> family)
		{
		}

		public IEqualityComparer<HashSet<TEl>> memberEq {
			get { return this.Comparer; }
		}
		[Obsolete()]
		public IEqualityComparer<SetI1<TEl>> elementEq
		{
			get
			{
				return  new nilnul.obj.set.Eq<TEl>(_elEq);

				//throw new NotImplementedException();
			}
		}

		public IEqualityComparer<TEl> elEq => _elEq;

		public SetI1<TEl>[] toArr()
		{
			return this.Select(hashSet=> new nilnul.obj.Set1<TEl>(hashSet)).ToArray() ;

			//throw new NotImplementedException();
		}
	}
}
