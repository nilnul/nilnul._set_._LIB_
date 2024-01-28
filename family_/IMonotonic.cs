namespace nilnul.set.family_
{
	/// <summary>
	/// the sets are sortie with respect to <see cref="set.re_.ISubset"/>;
	/// </summary>
	/// <remarks>
	/// eg:
	///		{  }
	///		,
	///		{ phi }
	///		,
	///		{{a} }
	///		,
	///		{ {a}, {a,b}}
	///		{ {a}, {a,b}, {a,b,c}}
	/// </remarks>
	interface IMonotonic { }
}
