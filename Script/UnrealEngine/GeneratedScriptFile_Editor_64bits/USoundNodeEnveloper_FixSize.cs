#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Allows manipulation of volume and pitch over a set time period</summary>
	public partial class USoundNodeEnveloper
	{
		static readonly int LoopStart__Offset;
		/// <summary>The time in seconds where the envelope's loop begins.</summary>
		public float LoopStart
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LoopStart__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LoopStart__Offset, false);}
			
		}
		
		static readonly int LoopEnd__Offset;
		/// <summary>The time in seconds where the envelope's loop ends.</summary>
		public float LoopEnd
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LoopEnd__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LoopEnd__Offset, false);}
			
		}
		
		static readonly int DurationAfterLoop__Offset;
		/// <summary>The time in seconds it takes the evelope to fade out after the last loop is completed.</summary>
		public float DurationAfterLoop
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DurationAfterLoop__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DurationAfterLoop__Offset, false);}
			
		}
		
		static readonly int LoopCount__Offset;
		/// <summary>The number of times the envelope should loop if looping is enabled and the envelope is not set to loop indefinitely.</summary>
		public int LoopCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LoopCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LoopCount__Offset, false);}
			
		}
		
		static readonly int bLoopIndefinitely__Offset;
		/// <summary>If enabled, the envelope will continue to loop indefenitely regardless of the Loop Count value.</summary>
		public bool bLoopIndefinitely
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLoopIndefinitely__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLoopIndefinitely__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bLoop__Offset;
		/// <summary>If enabled, the envelope will loop using the loop settings.</summary>
		public bool bLoop
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLoop__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLoop__Offset, 1,0,2,2);}
			
		}
		
		static readonly int VolumeInterpCurve__Offset;
		public UDistributionFloatConstantCurve VolumeInterpCurve
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + VolumeInterpCurve__Offset); if (v == IntPtr.Zero)return null; UDistributionFloatConstantCurve retValue = new UDistributionFloatConstantCurve(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PitchInterpCurve__Offset;
		public UDistributionFloatConstantCurve PitchInterpCurve
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PitchInterpCurve__Offset); if (v == IntPtr.Zero)return null; UDistributionFloatConstantCurve retValue = new UDistributionFloatConstantCurve(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int VolumeCurve__Offset;
		/// <summary>The distribution defining the volume envelope.</summary>
		public FRuntimeFloatCurve VolumeCurve
		{
			get{ CheckIsValid();return (FRuntimeFloatCurve)Marshal.PtrToStructure(_this.Get()+VolumeCurve__Offset, typeof(FRuntimeFloatCurve));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeCurve__Offset, false);}
			
		}
		
		static readonly int PitchCurve__Offset;
		/// <summary>The distribution defining the pitch envelope.</summary>
		public FRuntimeFloatCurve PitchCurve
		{
			get{ CheckIsValid();return (FRuntimeFloatCurve)Marshal.PtrToStructure(_this.Get()+PitchCurve__Offset, typeof(FRuntimeFloatCurve));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchCurve__Offset, false);}
			
		}
		
		static readonly int PitchMin__Offset;
		/// <summary>The lower bound of pitch (1.0 is no change)</summary>
		public float PitchMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PitchMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchMin__Offset, false);}
			
		}
		
		static readonly int PitchMax__Offset;
		/// <summary>The upper bound of pitch (1.0 is no change)</summary>
		public float PitchMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PitchMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchMax__Offset, false);}
			
		}
		
		static readonly int VolumeMin__Offset;
		/// <summary>The lower bound of volume (1.0 is no change)</summary>
		public float VolumeMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeMin__Offset, false);}
			
		}
		
		static readonly int VolumeMax__Offset;
		/// <summary>The upper bound of volume (1.0 is no change)</summary>
		public float VolumeMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeMax__Offset, false);}
			
		}
		
		static USoundNodeEnveloper()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeEnveloper");
			LoopStart__Offset=GetPropertyOffset(NativeClassPtr,"LoopStart");
			LoopEnd__Offset=GetPropertyOffset(NativeClassPtr,"LoopEnd");
			DurationAfterLoop__Offset=GetPropertyOffset(NativeClassPtr,"DurationAfterLoop");
			LoopCount__Offset=GetPropertyOffset(NativeClassPtr,"LoopCount");
			bLoopIndefinitely__Offset=GetPropertyOffset(NativeClassPtr,"bLoopIndefinitely");
			bLoop__Offset=GetPropertyOffset(NativeClassPtr,"bLoop");
			VolumeInterpCurve__Offset=GetPropertyOffset(NativeClassPtr,"VolumeInterpCurve");
			PitchInterpCurve__Offset=GetPropertyOffset(NativeClassPtr,"PitchInterpCurve");
			VolumeCurve__Offset=GetPropertyOffset(NativeClassPtr,"VolumeCurve");
			PitchCurve__Offset=GetPropertyOffset(NativeClassPtr,"PitchCurve");
			PitchMin__Offset=GetPropertyOffset(NativeClassPtr,"PitchMin");
			PitchMax__Offset=GetPropertyOffset(NativeClassPtr,"PitchMax");
			VolumeMin__Offset=GetPropertyOffset(NativeClassPtr,"VolumeMin");
			VolumeMax__Offset=GetPropertyOffset(NativeClassPtr,"VolumeMax");
			
		}
		
	}
	
}
#endif
#endif
