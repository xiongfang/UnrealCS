#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Parameters that apply to a destructible actor.</summary>
	[StructLayout(LayoutKind.Explicit,Size=136)]
	public partial struct FDestructibleParameters
	{
		/// <summary>Parameters that pertain to chunk damage.  See DestructibleDamageParameters.</summary>
		[FieldOffset(0)]
		public FDestructibleDamageParameters DamageParameters;
		/// <summary>Parameters that pertain to chunk debris-level settings.  See DestructibleDebrisParameters.</summary>
		[FieldOffset(28)]
		public FDestructibleDebrisParameters DebrisParameters;
		/// <summary>Parameters that are less-often used.  See DestructibleAdvancedParameters.</summary>
		[FieldOffset(72)]
		public FDestructibleAdvancedParameters AdvancedParameters;
		/// <summary>Special hierarchy depths for various behaviors.</summary>
		[FieldOffset(88)]
		public FDestructibleSpecialHierarchyDepths SpecialHierarchyDepths;
		/// <summary>
		/// Parameters that apply to every chunk at a given level.
		/// the element [0] of the array applies to the level 0 (unfractured) chunk, element [1] applies
		/// to the level 1 chunks, etc.
		/// </summary>
		public TStructArray<FDestructibleDepthParameters> DepthParameters
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FDestructibleDepthParameters>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+112, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+112, false);}}}
			
		}
		/// <summary>A collection of flags defined in DestructibleParametersFlag.</summary>
		[FieldOffset(128)]
		public FDestructibleParametersFlag Flags;
		
	}
	
}
#endif
#endif
