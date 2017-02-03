#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ADebugCameraController
	{
		static readonly int bShowSelectedInfo__Offset;
		public bool bShowSelectedInfo
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowSelectedInfo__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bIsFrozenRendering__Offset;
		public bool bIsFrozenRendering
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsFrozenRendering__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int DrawFrustum__Offset;
		public UDrawFrustumComponent DrawFrustum
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DrawFrustum__Offset); if (v == IntPtr.Zero)return null; UDrawFrustumComponent retValue = new UDrawFrustumComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpeedScale__Offset;
		public float SpeedScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpeedScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpeedScale__Offset, false);}
			
		}
		
		static readonly int InitialMaxSpeed__Offset;
		public float InitialMaxSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialMaxSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialMaxSpeed__Offset, false);}
			
		}
		
		static readonly int InitialAccel__Offset;
		public float InitialAccel
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialAccel__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialAccel__Offset, false);}
			
		}
		
		static readonly int InitialDecel__Offset;
		public float InitialDecel
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialDecel__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialDecel__Offset, false);}
			
		}
		
		static ADebugCameraController()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DebugCameraController");
			bShowSelectedInfo__Offset=GetPropertyOffset(NativeClassPtr,"bShowSelectedInfo");
			bIsFrozenRendering__Offset=GetPropertyOffset(NativeClassPtr,"bIsFrozenRendering");
			DrawFrustum__Offset=GetPropertyOffset(NativeClassPtr,"DrawFrustum");
			SpeedScale__Offset=GetPropertyOffset(NativeClassPtr,"SpeedScale");
			InitialMaxSpeed__Offset=GetPropertyOffset(NativeClassPtr,"InitialMaxSpeed");
			InitialAccel__Offset=GetPropertyOffset(NativeClassPtr,"InitialAccel");
			InitialDecel__Offset=GetPropertyOffset(NativeClassPtr,"InitialDecel");
			
		}
		
	}
	
}
#endif
#endif
