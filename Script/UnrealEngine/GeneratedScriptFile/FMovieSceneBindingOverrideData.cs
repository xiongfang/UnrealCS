using System;
namespace UnrealEngine
{
	/// <summary>Movie scene binding override data</summary>
	public partial struct FMovieSceneBindingOverrideData
	{
		/// <summary>Specifies the object binding to override.</summary>
		public FMovieSceneObjectBindingPtr ObjectBindingId;
		/// <summary>Specifies whether the default assignment should remain bound (false) or if this should completely override the default binding (false).</summary>
		public bool bOverridesDefault;
		
	}
	
}
