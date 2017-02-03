#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Selects sounds from a random set</summary>
	public partial class USoundNodeRandom
	{
		static readonly int Weights__Offset;
		public TStructArray<float> Weights
		{
			get{ CheckIsValid();return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Weights__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Weights__Offset, false);}
			
		}
		
		static readonly int PreselectAtLevelLoad__Offset;
		/// <summary>
		/// If greater than 0, then upon each level load such a number of inputs will be randomly selected
		/// and the rest will be removed. This can be used to cut down the memory usage of large randomizing
		/// cues.
		/// </summary>
		public int PreselectAtLevelLoad
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PreselectAtLevelLoad__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PreselectAtLevelLoad__Offset, false);}
			
		}
		
		static readonly int bRandomizeWithoutReplacement__Offset;
		/// <summary>
		/// Determines whether or not this SoundNodeRandom should randomize with or without
		/// replacement.
		/// WithoutReplacement means that only nodes left will be valid for
		/// selection.  So with that, you are guarenteed to have only one occurrence of the
		/// sound played until all of the other sounds in the set have all been played.
		/// WithReplacement means that a node will be chosen and then placed back into the set.
		/// So one could play the same sound over and over if the probabilities don't go your way :-)
		/// </summary>
		public bool bRandomizeWithoutReplacement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRandomizeWithoutReplacement__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRandomizeWithoutReplacement__Offset, 1,0,1,1);}
			
		}
		
		static readonly int HasBeenUsed__Offset;
		/// <summary>
		/// Internal state of which sounds have been played.  This is only used at runtime
		/// to keep track of which sounds have been played
		/// </summary>
		public TStructArray<bool> HasBeenUsed
		{
			get{ CheckIsValid();return new TStructArray<bool>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HasBeenUsed__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HasBeenUsed__Offset, false);}
			
		}
		
		static readonly int NumRandomUsed__Offset;
		/// <summary>Counter var so we don't have to count all of the used sounds each time we choose a sound *</summary>
		public int NumRandomUsed
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumRandomUsed__Offset, typeof(int));}
			
		}
		
		static readonly int PIEHiddenNodes__Offset;
		/// <summary>Editor only list of nodes hidden to duplicate behavior of PreselectAtLevelLoad</summary>
		public TStructArray<int> PIEHiddenNodes
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PIEHiddenNodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PIEHiddenNodes__Offset, false);}
			
		}
		
		static USoundNodeRandom()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeRandom");
			Weights__Offset=GetPropertyOffset(NativeClassPtr,"Weights");
			PreselectAtLevelLoad__Offset=GetPropertyOffset(NativeClassPtr,"PreselectAtLevelLoad");
			bRandomizeWithoutReplacement__Offset=GetPropertyOffset(NativeClassPtr,"bRandomizeWithoutReplacement");
			HasBeenUsed__Offset=GetPropertyOffset(NativeClassPtr,"HasBeenUsed");
			NumRandomUsed__Offset=GetPropertyOffset(NativeClassPtr,"NumRandomUsed");
			PIEHiddenNodes__Offset=GetPropertyOffset(NativeClassPtr,"PIEHiddenNodes");
			
		}
		
	}
	
}
#endif
#endif
