#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AMaterialInstanceActor
	{
		static readonly int TargetActors__Offset;
		public TObjectArray<AActor>  TargetActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TargetActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TargetActors__Offset, false);}
			
		}
		
		static AMaterialInstanceActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialInstanceActor");
			TargetActors__Offset=GetPropertyOffset(NativeClassPtr,"TargetActors");
			
		}
		
	}
	
}
#endif
#endif
