#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A CameraShake is an asset that defines how to shake the camera in
	/// a particular way. CameraShakes can be authored as either oscillating shakes,
	/// animated shakes, or both.
	/// An oscillating shake will sinusoidally vibrate various camera parameters over time. Each location
	/// and rotation axis can be oscillated independently with different parameters to create complex and
	/// random-feeling shakes. These are easier to author and tweak, but can still feel mechanical and are
	/// limited to vibration-style shakes, such as earthquakes.
	/// Animated shakes play keyframed camera animations.  These can take more effort to author, but enable
	/// more natural-feeling results and things like directional shakes.  For instance, you can have an explosion
	/// to the camera's right push it primarily to the left.
	/// </summary>
	public partial class UCameraShake
	{
		static readonly int bSingleInstance__Offset;
		/// <summary>
		/// If true to only allow a single instance of this shake class to play at any given time.
		/// Subsequent attempts to play this shake will simply restart the timer.
		/// </summary>
		public bool bSingleInstance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSingleInstance__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSingleInstance__Offset, 1,0,1,1);}
			
		}
		
		static readonly int OscillationDuration__Offset;
		/// <summary>Duration in seconds of current screen shake. Less than 0 means indefinite, 0 means no oscillation.</summary>
		public float OscillationDuration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OscillationDuration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OscillationDuration__Offset, false);}
			
		}
		
		static readonly int OscillationBlendInTime__Offset;
		/// <summary>Duration of the blend-in, where the oscillation scales from 0 to 1.</summary>
		public float OscillationBlendInTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OscillationBlendInTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OscillationBlendInTime__Offset, false);}
			
		}
		
		static readonly int OscillationBlendOutTime__Offset;
		/// <summary>Duration of the blend-out, where the oscillation scales from 1 to 0.</summary>
		public float OscillationBlendOutTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OscillationBlendOutTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OscillationBlendOutTime__Offset, false);}
			
		}
		
		static readonly int RotOscillation__Offset;
		/// <summary>Rotational oscillation</summary>
		public FROscillator RotOscillation
		{
			get{ CheckIsValid();return (FROscillator)Marshal.PtrToStructure(_this.Get()+RotOscillation__Offset, typeof(FROscillator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotOscillation__Offset, false);}
			
		}
		
		static readonly int LocOscillation__Offset;
		/// <summary>Positional oscillation</summary>
		public FVOscillator LocOscillation
		{
			get{ CheckIsValid();return (FVOscillator)Marshal.PtrToStructure(_this.Get()+LocOscillation__Offset, typeof(FVOscillator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LocOscillation__Offset, false);}
			
		}
		
		static readonly int FOVOscillation__Offset;
		/// <summary>FOV oscillation</summary>
		public FFOscillator FOVOscillation
		{
			get{ CheckIsValid();return (FFOscillator)Marshal.PtrToStructure(_this.Get()+FOVOscillation__Offset, typeof(FFOscillator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FOVOscillation__Offset, false);}
			
		}
		
		static readonly int AnimPlayRate__Offset;
		/// <summary>Scalar defining how fast to play the anim.</summary>
		public float AnimPlayRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimPlayRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimPlayRate__Offset, false);}
			
		}
		
		static readonly int AnimScale__Offset;
		/// <summary>Scalar defining how "intense" to play the anim.</summary>
		public float AnimScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimScale__Offset, false);}
			
		}
		
		static readonly int AnimBlendInTime__Offset;
		/// <summary>Linear blend-in time.</summary>
		public float AnimBlendInTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimBlendInTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimBlendInTime__Offset, false);}
			
		}
		
		static readonly int AnimBlendOutTime__Offset;
		/// <summary>Linear blend-out time.</summary>
		public float AnimBlendOutTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimBlendOutTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimBlendOutTime__Offset, false);}
			
		}
		
		static readonly int RandomAnimSegmentDuration__Offset;
		/// <summary>When bRandomAnimSegment is true, this defines how long the anim should play.</summary>
		public float RandomAnimSegmentDuration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RandomAnimSegmentDuration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RandomAnimSegmentDuration__Offset, false);}
			
		}
		
		static readonly int Anim__Offset;
		/// <summary>Source camera animation to play. Can be null.</summary>
		public UCameraAnim Anim
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Anim__Offset); if (v == IntPtr.Zero)return null; UCameraAnim retValue = new UCameraAnim(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Anim__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Anim__Offset, value._this.Get()); }
			
		}
		
		static readonly int bRandomAnimSegment__Offset;
		/// <summary>
		/// If true, play a random snippet of the animation of length Duration.  Implies bLoop and bRandomStartTime = true for the CameraAnim.
		/// If false, play the full anim once, non-looped. Useful for getting variety out of a single looped CameraAnim asset.
		/// </summary>
		public bool bRandomAnimSegment
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRandomAnimSegment__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRandomAnimSegment__Offset, 1,0,1,1);}
			
		}
		
		static readonly int CameraOwner__Offset;
		public APlayerCameraManager CameraOwner
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraOwner__Offset); if (v == IntPtr.Zero)return null; APlayerCameraManager retValue = new APlayerCameraManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ShakeScale__Offset;
		/// <summary>Overall intensity scale for this shake instance.</summary>
		public float ShakeScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShakeScale__Offset, typeof(float));}
			
		}
		
		static readonly int OscillatorTimeRemaining__Offset;
		/// <summary>Time remaining for oscillation shakes. Less than 0.f means shake infinitely.</summary>
		public float OscillatorTimeRemaining
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OscillatorTimeRemaining__Offset, typeof(float));}
			
		}
		
		static readonly int AnimInst__Offset;
		/// <summary>The playing instance of the CameraAnim-based shake, if any.</summary>
		public UCameraAnimInst AnimInst
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimInst__Offset); if (v == IntPtr.Zero)return null; UCameraAnimInst retValue = new UCameraAnimInst(); retValue._this = v; return retValue; }
			
		}
		
		static UCameraShake()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CameraShake");
			bSingleInstance__Offset=GetPropertyOffset(NativeClassPtr,"bSingleInstance");
			OscillationDuration__Offset=GetPropertyOffset(NativeClassPtr,"OscillationDuration");
			OscillationBlendInTime__Offset=GetPropertyOffset(NativeClassPtr,"OscillationBlendInTime");
			OscillationBlendOutTime__Offset=GetPropertyOffset(NativeClassPtr,"OscillationBlendOutTime");
			RotOscillation__Offset=GetPropertyOffset(NativeClassPtr,"RotOscillation");
			LocOscillation__Offset=GetPropertyOffset(NativeClassPtr,"LocOscillation");
			FOVOscillation__Offset=GetPropertyOffset(NativeClassPtr,"FOVOscillation");
			AnimPlayRate__Offset=GetPropertyOffset(NativeClassPtr,"AnimPlayRate");
			AnimScale__Offset=GetPropertyOffset(NativeClassPtr,"AnimScale");
			AnimBlendInTime__Offset=GetPropertyOffset(NativeClassPtr,"AnimBlendInTime");
			AnimBlendOutTime__Offset=GetPropertyOffset(NativeClassPtr,"AnimBlendOutTime");
			RandomAnimSegmentDuration__Offset=GetPropertyOffset(NativeClassPtr,"RandomAnimSegmentDuration");
			Anim__Offset=GetPropertyOffset(NativeClassPtr,"Anim");
			bRandomAnimSegment__Offset=GetPropertyOffset(NativeClassPtr,"bRandomAnimSegment");
			CameraOwner__Offset=GetPropertyOffset(NativeClassPtr,"CameraOwner");
			ShakeScale__Offset=GetPropertyOffset(NativeClassPtr,"ShakeScale");
			OscillatorTimeRemaining__Offset=GetPropertyOffset(NativeClassPtr,"OscillatorTimeRemaining");
			AnimInst__Offset=GetPropertyOffset(NativeClassPtr,"AnimInst");
			
		}
		
	}
	
}
#endif
#endif
