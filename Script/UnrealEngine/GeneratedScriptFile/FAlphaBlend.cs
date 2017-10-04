using System;
namespace UnrealEngine
{
	/// <summary>Alpha Blend class that supports different blend options as well as custom curves</summary>
	public partial struct FAlphaBlend
	{
		/// <summary>If you're using Custom BlendOption, you can specify curve</summary>
		public UCurveFloat CustomCurve;
		/// <summary>Blend Time</summary>
		public float BlendTime;
		
	}
	
}
