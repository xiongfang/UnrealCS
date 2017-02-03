#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Entry for a delegate to assign after a blueprint has been instanced</summary>
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FBlueprintComponentDelegateBinding
	{
		/// <summary>Name of component property that contains delegate we want to assign to.</summary>
		[FieldOffset(0)]
		public FName ComponentPropertyName;
		/// <summary>Name of property on the component that we want to assign to.</summary>
		[FieldOffset(12)]
		public FName DelegatePropertyName;
		/// <summary>Name of function that we want to bind to the delegate.</summary>
		[FieldOffset(24)]
		public FName FunctionNameToBind;
		
	}
	
}
#endif
#endif
