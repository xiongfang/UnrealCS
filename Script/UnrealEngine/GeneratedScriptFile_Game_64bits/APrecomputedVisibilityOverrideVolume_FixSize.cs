#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class APrecomputedVisibilityOverrideVolume
	{
		static readonly int OverrideVisibleActors__Offset;
		public TObjectArray<AActor>  OverrideVisibleActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+OverrideVisibleActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+OverrideVisibleActors__Offset, false);}
			
		}
		
		static readonly int OverrideInvisibleActors__Offset;
		public TObjectArray<AActor>  OverrideInvisibleActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+OverrideInvisibleActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+OverrideInvisibleActors__Offset, false);}
			
		}
		
		static readonly int OverrideInvisibleLevels__Offset;
		public TStructArray<FName> OverrideInvisibleLevels
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+OverrideInvisibleLevels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+OverrideInvisibleLevels__Offset, false);}
			
		}
		
		static APrecomputedVisibilityOverrideVolume()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PrecomputedVisibilityOverrideVolume");
			OverrideVisibleActors__Offset=GetPropertyOffset(NativeClassPtr,"OverrideVisibleActors");
			OverrideInvisibleActors__Offset=GetPropertyOffset(NativeClassPtr,"OverrideInvisibleActors");
			OverrideInvisibleLevels__Offset=GetPropertyOffset(NativeClassPtr,"OverrideInvisibleLevels");
			
		}
		
	}
	
}
#endif
#endif
