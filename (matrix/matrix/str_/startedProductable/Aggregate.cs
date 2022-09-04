using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.matrix.str.be_;

namespace nilnul.matrix.str_.startedProductable
{
	public class Aggregate<T>
		: OpI<str.be_.StartedProductable<T>.En, T[,]>
	{
		private nilnul.matrix.duo_.associable.InnerProduct<T> _multi;

		public nilnul.matrix.duo_.associable.InnerProduct<T> multi
		{
			get { return _multi; }
			//set { _multi = value; }
		}

		public Aggregate(
			nilnul.matrix.duo_.associable.InnerProduct<T> op	
		)
		{
			_multi = op;
		}

		public T[,] _eval(IEnumerable<T[,]>  _arg_startedProductable)
		{
			var skipped = _arg_startedProductable.Skip(1);

			if (skipped.Any())
			{
				return _multi._eval(
					_arg_startedProductable.First()
					,

					_eval(skipped)

				);

			}
			else
			{
				return _arg_startedProductable.First();
			}


		}

		public T[,] _eval(params T[][,]  _arg_startedProductable)
		{
			return _eval(_arg_startedProductable as  IEnumerable<T[,]>);


		}
		public T[,] eval(StartedProductable<T>.En arg)
		{
			return _eval(arg.asserted);


		}

		
	}
}
