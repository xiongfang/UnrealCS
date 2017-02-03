#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimNotify_PlaySound
	{
		static readonly int Sound__Offset;
		/// <summary>Sound to Play</summary>
		public USoundBase Sound
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Sound__Offset); if (v == IntPtr.Zero)return null; USoundBase retValue = new USoundBase(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Sound__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Sound__Offset, value._this.Get()); }
			
		}
		
		static readonly int VolumeMultiplier__Offset;
		/// <summary>Volume Multiplier</summary>
		public float VolumeMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeMultiplier__Offset, false);}
			
		}
		
		static readonly int PitchMultiplier__Offset;
		/// <summary>Pitch Multiplier</summary>
		public float PitchMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PitchMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchMultiplier__Offset, false);}
			
		}
		
		static readonly int bFollow__Offset;
		/// <summary>If this sound should follow its owner</summary>
		public bool bFollow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFollow__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFollow__Offset, 1,0,1,1);}
			
		}
		
		static readonly int AttachName__Offset;
		/// <summary>Socket or bone name to attach sound to</summary>
		public FName AttachName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+AttachName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AttachName__Offset, false);}
			
		}
		
		static UAnimNotify_PlaySound()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimNotify_PlaySound");
			Sound__Offset=GetPropertyOffset(NativeClassPtr,"Sound");
			VolumeMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"VolumeMultiplier");
			PitchMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"PitchMultiplier");
			bFollow__Offset=GetPropertyOffset(NativeClassPtr,"bFollow");
			AttachName__Offset=GetPropertyOffset(NativeClassPtr,"AttachName");
			
		}
		
	}
	
}
#endif
#endif
