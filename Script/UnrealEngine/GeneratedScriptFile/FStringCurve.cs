using System;
namespace UnrealEngine
{
	/// <summary>Implements a curve of FStrings.</summary>
	public partial struct FStringCurve
	{
		/// <summary>Default value</summary>
		public FString DefaultValue;
		/// <summary>Map of which key handles go to which indices.</summary>
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
