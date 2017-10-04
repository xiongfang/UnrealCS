using System;
namespace UnrealEngine
{
	/// <summary>An integral curve, which holds the key time and the key value</summary>
	public partial struct FIntegralCurve
	{
		/// <summary>Default value</summary>
		public int DefaultValue;
		public bool bUseDefaultValueBeforeFirstKey;
		/// <summary>Map of which key handles go to which indices.</summary>
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
