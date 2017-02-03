#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FDialogueContext
	{
		/// <summary>The person speaking the dialogue.</summary>
		/// <summary>The people being spoken to.</summary>
		public TObjectArray<UDialogueVoice> Targets
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UDialogueVoice>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+8, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+8, false);}}}
			
		}
		
	}
	
}
#endif
#endif
