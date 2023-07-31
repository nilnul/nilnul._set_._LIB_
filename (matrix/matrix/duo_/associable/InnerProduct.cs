using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._op;
using nilnul.matrix.duo.be_;
using nilnul.matrix;

namespace nilnul.matrix.duo_.associable
{
	public class InnerProduct<TElement>
		: nilnul.OpI<
			matrix.duo.be_.Associable<TElement>.En, TElement[,]
		>
	{

		private nilnul.duo.OpI<TElement> _elementDuoOp;

		public nilnul.duo.OpI<TElement> elementDuoOp
		{
			get { return _elementDuoOp; }
			set { _elementDuoOp = value; }
		}

		private nilnul.str.AggregateI<TElement> _aggregate;

		public nilnul.str.AggregateI<TElement> aggregate
		{
			get { return _aggregate; }
			set { _aggregate = value; }
		}


		public InnerProduct(
			nilnul.duo.OpI<TElement> elementDuoOp
			,nilnul.str.AggregateI<TElement> aggregate
		)
		{
			_elementDuoOp = elementDuoOp;
			_aggregate = aggregate;
		}

		public InnerProduct(

			Func<TElement,TElement,TElement> duoOp
			,
			Func<IEnumerable<TElement>, TElement> aggregate
			
		)
			:this(
				new nilnul.duo.Op<TElement>(duoOp)	
				 ,
				new nilnul.str.Aggregate<TElement>(aggregate) 
			)
		{

		}



		public TElement[,] _eval(
			TElement[,] a
			,
			TElement[,] b
			
			) {

			var r = new TElement[
				a.GetLength(0)
				,
				b.GetLength(1)
			];

			for (int i = 0; i < r.GetLength(0); i++)
			{
				for (int j = 0; j < r.GetLength(1); j++)
				{
					r[i, j] = nilnul.str.duo_.sameLen.ZipSum<TElement>._Eval(
					 nilnul.matrix.Extensions.Row(
						a
						, i)
					,
					 nilnul.matrix.Extensions.Column(b
					 , j)
					 ,
					 elementDuoOp
					 ,
					 aggregate

				);

				}

			}

			return r;


		}
		public TElement[,] eval(Associable<TElement>.En arg
			//,
			//Func<TElement, TElement, TElement> duoOp
			//,
			//nilnul.str.AggregateI<TElement> aggregate

			)
		{
			

			return _eval(arg.asserted.Item1, arg.asserted.Item2);

			//throw new NotImplementedException();
		}


		

	}
}
