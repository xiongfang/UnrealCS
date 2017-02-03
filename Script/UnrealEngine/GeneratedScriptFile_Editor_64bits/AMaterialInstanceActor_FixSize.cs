#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AMaterialInstanceActor
	{
		static readonly int TargetActors__Offset;
		/// <summary>Pointer to actors that we want to control paramters of using Matinee.</summary>
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
