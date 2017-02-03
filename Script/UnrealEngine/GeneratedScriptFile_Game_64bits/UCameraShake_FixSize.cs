#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCameraShake
	{
		static readonly int bSingleInstance__Offset;
		public bool bSingleInstance
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSingleInstance__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSingleInstance__Offset, 1,0,1,1);}
			
		}
		
		static readonly int OscillationDuration__Offset;
		public float OscillationDuration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OscillationDuration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OscillationDuration__Offset, false);}
			
		}
		
		static readonly int OscillationBlendInTime__Offset;
		public float OscillationBlendInTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OscillationBlendInTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OscillationBlendInTime__Offset, false);}
			
		}
		
		static readonly int OscillationBlendOutTime__Offset;
		public float OscillationBlendOutTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OscillationBlendOutTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OscillationBlendOutTime__Offset, false);}
			
		}
		
		static readonly int RotOscillation__Offset;
		public FROscillator RotOscillation
		{
			get{ CheckIsValid();return (FROscillator)Marshal.PtrToStructure(_this.Get()+RotOscillation__Offset, typeof(FROscillator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotOscillation__Offset, false);}
			
		}
		
		static readonly int LocOscillation__Offset;
		public FVOscillator LocOscillation
		{
			get{ CheckIsValid();return (FVOscillator)Marshal.PtrToStructure(_this.Get()+LocOscillation__Offset, typeof(FVOscillator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LocOscillation__Offset, false);}
			
		}
		
		static readonly int FOVOscillation__Offset;
		public FFOscillator FOVOscillation
		{
			get{ CheckIsValid();return (FFOscillator)Marshal.PtrToStructure(_this.Get()+FOVOscillation__Offset, typeof(FFOscillator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FOVOscillation__Offset, false);}
			
		}
		
		static readonly int AnimPlayRate__Offset;
		public float AnimPlayRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimPlayRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimPlayRate__Offset, false);}
			
		}
		
		static readonly int AnimScale__Offset;
		public float AnimScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimScale__Offset, false);}
			
		}
		
		static readonly int AnimBlendInTime__Offset;
		public float AnimBlendInTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimBlendInTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimBlendInTime__Offset, false);}
			
		}
		
		static readonly int AnimBlendOutTime__Offset;
		public float AnimBlendOutTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimBlendOutTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AnimBlendOutTime__Offset, false);}
			
		}
		
		static readonly int RandomAnimSegmentDuration__Offset;
		public float RandomAnimSegmentDuration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RandomAnimSegmentDuration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RandomAnimSegmentDuration__Offset, false);}
			
		}
		
		static readonly int Anim__Offset;
		public UCameraAnim Anim
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Anim__Offset); if (v == IntPtr.Zero)return null; UCameraAnim retValue = new UCameraAnim(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Anim__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Anim__Offset, value._this.Get()); }
			
		}
		
		static readonly int bRandomAnimSegment__Offset;
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
		public float ShakeScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShakeScale__Offset, typeof(float));}
			
		}
		
		static readonly int OscillatorTimeRemaining__Offset;
		public float OscillatorTimeRemaining
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OscillatorTimeRemaining__Offset, typeof(float));}
			
		}
		
		static readonly int AnimInst__Offset;
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
