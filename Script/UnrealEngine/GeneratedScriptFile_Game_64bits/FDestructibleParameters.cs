#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=136)]
	public partial struct FDestructibleParameters
	{
		[FieldOffset(0)]
		public FDestructibleDamageParameters DamageParameters;
		[FieldOffset(28)]
		public FDestructibleDebrisParameters DebrisParameters;
		[FieldOffset(72)]
		public FDestructibleAdvancedParameters AdvancedParameters;
		[FieldOffset(88)]
		public FDestructibleSpecialHierarchyDepths SpecialHierarchyDepths;
		public TStructArray<FDestructibleDepthParameters> DepthParameters
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FDestructibleDepthParameters>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+112, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+112, false);}}}
			
		}
		[FieldOffset(128)]
		public FDestructibleParametersFlag Flags;
		
	}
	
}
#endif
#endif
