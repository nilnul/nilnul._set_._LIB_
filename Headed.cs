using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.collection
{

	public class Headed<T>
		: Headed<T,IEnumerable<T>>
		
	{
		
		public Headed(T head, IEnumerable<T> tail)
			:base(head,tail)
		{
			
		}

	}

	public class Headed<T,TTail>
		:IEnumerable<T>
		where TTail:IEnumerable<T>
	{
		private T _head;

		public T head
		{
			get { return _head; }
			set { _head = value; }
		}

		private TTail _tail;

		public TTail tail
		{
			get { return _tail; }
			set { _tail = value; }
		}
		public Headed(T head, TTail tail)
		{
			_head = head;
			_tail = tail;
		}

		public IEnumerator<T> GetEnumerator()
		{
			yield return _head;
			foreach (var item in _tail)
			{
				yield return item;
			}
			//yield break;
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}


	[Obsolete("Headed")]

	public class HeadedS<T>
		: IEnumerable<T>
	{
		private T _head;

		public T head
		{
			get { return _head; }
			set { _head = value; }
		}

		private IEnumerable<T> _tail;

		public IEnumerable<T> tail
		{
			get { return _tail; }
			set { _tail = value; }
		}
		public HeadedS(T head, IEnumerable<T> tail)
		{
			_head = head;
			_tail = tail;

		}



		public IEnumerator<T> GetEnumerator()
		{
			yield return _head;
			foreach (var item in _tail)
			{
				yield return item;

			}

			//yield break;

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
