using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.algebra_.pargoid_.delta.be_.dwelt_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///		
	public class Magma_byIndex<T> : nilnul.set.family.BeI<T>
		,
		delta.BeI_ofFamily<T>
	{

		public bool _be_assumeDwelt(Family<T> obj)
		{



			if (obj.Contains(
				new HashSet<T>(obj.First().Comparer)
			))
			{

				for (int i = 0; i < obj.Count; i++)
				{
					for (int j = i; j < obj.Count; j++)
					{
						if (!obj.Contains(
								nilnul.set.op_.binary_.Delta<T>.Singleton.op(
								 obj.ElementAt(i), obj.ElementAt(j)
								)
							 )
						)
						{
							return false;

						}

					}

				}
				return true;

			}
			else
			{
				return false; //x delta x = empty
			}





		}

		public bool be(Family<T> obj)
		{

			if (obj.Any())
			{


				return _be_assumeDwelt(obj);


			}
			else
			{
				return false;

			}


		}


		static public Magma_byIndex<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Magma_byIndex<T>>.Instance;
			}
		}

	}
}
