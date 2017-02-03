#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackAnimControl
	{
		static readonly int SlotName__Offset;
		public FName SlotName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SlotName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SlotName__Offset, false);}
			
		}
		
		static readonly int AnimSeqs__Offset;
		public TStructArray<FAnimControlTrackKey> AnimSeqs
		{
			get{ CheckIsValid();return new TStructArray<FAnimControlTrackKey>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AnimSeqs__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AnimSeqs__Offset, false);}
			
		}
		
		static readonly int bSkipAnimNotifiers__Offset;
		public bool bSkipAnimNotifiers
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSkipAnimNotifiers__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSkipAnimNotifiers__Offset, 1,0,1,1);}
			
		}
		
		static UInterpTrackAnimControl()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackAnimControl");
			SlotName__Offset=GetPropertyOffset(NativeClassPtr,"SlotName");
			AnimSeqs__Offset=GetPropertyOffset(NativeClassPtr,"AnimSeqs");
			bSkipAnimNotifiers__Offset=GetPropertyOffset(NativeClassPtr,"bSkipAnimNotifiers");
			
		}
		
	}
	
}
#endif
#endif
