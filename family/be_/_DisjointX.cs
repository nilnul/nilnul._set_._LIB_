using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family.be_
{
	static public class _DisjointX
	{

		static public bool Be<T>(IEnumerable<IEnumerable<T>> family
			,
IEqualityComparer<T> eq
		)
		{
			var counts = family.Count();
			for (int i = 0; i < counts; i++)
			{
				for (int j = i + 1; j < counts; j++)
				{
					if (
						re_._JointX.Re(
							(family).ElementAt(i)
							,
							(family).ElementAt(j)
							,
							eq
						)
					)
					{
						return false;
					}
				}
			}
			return true;
		}

		static public bool Be<T, TEq>(IEnumerable<IEnumerable<T>> family)
		where TEq : IEqualityComparer<T>, new()
		{
			return Be<T>(family, nilnul.obj_.Singleton<TEq>.Instance);
		}
		static public bool Be<T, TEq>(nilnul.set.Family<T, TEq> family)
				where TEq : IEqualityComparer<T>, new()
		{
			var counts = family.Count;
			for (int i = 0; i < counts; i++)
			{
				for (int j = i + 1; j < counts; j++)
				{
					if (
						re_._JointX.Re(
							(family).ElementAt(i)
							,
							(family).ElementAt(j)
						)
					)
					{
						return false;
					}
				}
			}
			return true;
		}

	}
}