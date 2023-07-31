using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.set.family
{
	/// <summary>
	/// universal set can be member of the family, or can be nonmember.
	/// universal set must be the superset of any member. It can eq to a member, or it can be supProp of any member.
	/// we use the name of univ, not omega, and they are totally different concept as omega is used in <see cref="set.op_.unary_.IComplement{TEl}"/>, which doesnot mean, nor need to be a univ of any family.
	/// 
	/// </summary>
	/// universe
	/// univ
	///		it is the superset (eq or ne) of the unison of the family.
	/// 
	public interface IUniv
	{
	}
}
