#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A vector parameter</summary>
	[StructLayout(LayoutKind.Explicit,Size=44)]
	public partial struct FCollectionVectorParameter
	{
		[FieldOffset(28)]
		public FLinearColor DefaultValue;
		/// <summary>The name of the parameter.  Changing this name will break any blueprints that reference the parameter.</summary>
		[FieldOffset(0)]
		public FName ParameterName;
		/// <summary>Uniquely identifies the parameter, used for fixing up materials that reference this parameter when renaming.</summary>
		[FieldOffset(12)]
		public FGuid Id;
		
	}
	
}
#endif
#endif
