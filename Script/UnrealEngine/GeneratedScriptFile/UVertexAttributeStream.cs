using System;
namespace UnrealEngine
{
	public partial class UVertexAttributeStream:UObject
	{
		/// <summary>e.g. FName(TEXT("Position"))</summary>
		public FName Usage;
		
		/// <summary>e.g. VAST_unknown</summary>
		public EVertexAttributeStreamType AttributeType;
		
		
	}
	
}
