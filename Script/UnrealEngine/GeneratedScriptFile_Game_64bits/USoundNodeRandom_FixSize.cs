#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundNodeRandom
	{
		static readonly int Weights__Offset;
		public TStructArray<float> Weights
		{
			get{ CheckIsValid();return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Weights__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Weights__Offset, false);}
			
		}
		
		static readonly int PreselectAtLevelLoad__Offset;
		public int PreselectAtLevelLoad
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PreselectAtLevelLoad__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreselectAtLevelLoad__Offset, false);}
			
		}
		
		static readonly int bRandomizeWithoutReplacement__Offset;
		public bool bRandomizeWithoutReplacement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRandomizeWithoutReplacement__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRandomizeWithoutReplacement__Offset, 1,0,1,1);}
			
		}
		
		static readonly int HasBeenUsed__Offset;
		public TStructArray<bool> HasBeenUsed
		{
			get{ CheckIsValid();return new TStructArray<bool>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HasBeenUsed__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HasBeenUsed__Offset, false);}
			
		}
		
		static readonly int NumRandomUsed__Offset;
		public int NumRandomUsed
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumRandomUsed__Offset, typeof(int));}
			
		}
		
		static USoundNodeRandom()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeRandom");
			Weights__Offset=GetPropertyOffset(NativeClassPtr,"Weights");
			PreselectAtLevelLoad__Offset=GetPropertyOffset(NativeClassPtr,"PreselectAtLevelLoad");
			bRandomizeWithoutReplacement__Offset=GetPropertyOffset(NativeClassPtr,"bRandomizeWithoutReplacement");
			HasBeenUsed__Offset=GetPropertyOffset(NativeClassPtr,"HasBeenUsed");
			NumRandomUsed__Offset=GetPropertyOffset(NativeClassPtr,"NumRandomUsed");
			
		}
		
	}
	
}
#endif
#endif
