#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USpringArmComponent
	{
		static readonly int TargetArmLength__Offset;
		public float TargetArmLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TargetArmLength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetArmLength__Offset, false);}
			
		}
		
		static readonly int SocketOffset__Offset;
		public FVector SocketOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+SocketOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SocketOffset__Offset, false);}
			
		}
		
		static readonly int TargetOffset__Offset;
		public FVector TargetOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+TargetOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetOffset__Offset, false);}
			
		}
		
		static readonly int ProbeSize__Offset;
		public float ProbeSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ProbeSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ProbeSize__Offset, false);}
			
		}
		
		static readonly int ProbeChannel__Offset;
		public ECollisionChannel ProbeChannel
		{
			get{ CheckIsValid();return (ECollisionChannel)Marshal.PtrToStructure(_this.Get()+ProbeChannel__Offset, typeof(ECollisionChannel));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ProbeChannel__Offset, false);}
			
		}
		
		static readonly int bDoCollisionTest__Offset;
		public bool bDoCollisionTest
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDoCollisionTest__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDoCollisionTest__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUsePawnControlRotation__Offset;
		public bool bUsePawnControlRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUsePawnControlRotation__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUsePawnControlRotation__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bInheritPitch__Offset;
		public bool bInheritPitch
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritPitch__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritPitch__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bInheritYaw__Offset;
		public bool bInheritYaw
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritYaw__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritYaw__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bInheritRoll__Offset;
		public bool bInheritRoll
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInheritRoll__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInheritRoll__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bEnableCameraLag__Offset;
		public bool bEnableCameraLag
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableCameraLag__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableCameraLag__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bEnableCameraRotationLag__Offset;
		public bool bEnableCameraRotationLag
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableCameraRotationLag__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableCameraRotationLag__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bUseCameraLagSubstepping__Offset;
		public bool bUseCameraLagSubstepping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseCameraLagSubstepping__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseCameraLagSubstepping__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bDrawDebugLagMarkers__Offset;
		public bool bDrawDebugLagMarkers
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawDebugLagMarkers__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawDebugLagMarkers__Offset, 1,0,1,1);}
			
		}
		
		static readonly int CameraLagSpeed__Offset;
		public float CameraLagSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraLagSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CameraLagSpeed__Offset, false);}
			
		}
		
		static readonly int CameraRotationLagSpeed__Offset;
		public float CameraRotationLagSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraRotationLagSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CameraRotationLagSpeed__Offset, false);}
			
		}
		
		static readonly int CameraLagMaxTimeStep__Offset;
		public float CameraLagMaxTimeStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraLagMaxTimeStep__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CameraLagMaxTimeStep__Offset, false);}
			
		}
		
		static readonly int CameraLagMaxDistance__Offset;
		public float CameraLagMaxDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CameraLagMaxDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CameraLagMaxDistance__Offset, false);}
			
		}
		
		static USpringArmComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SpringArmComponent");
			TargetArmLength__Offset=GetPropertyOffset(NativeClassPtr,"TargetArmLength");
			SocketOffset__Offset=GetPropertyOffset(NativeClassPtr,"SocketOffset");
			TargetOffset__Offset=GetPropertyOffset(NativeClassPtr,"TargetOffset");
			ProbeSize__Offset=GetPropertyOffset(NativeClassPtr,"ProbeSize");
			ProbeChannel__Offset=GetPropertyOffset(NativeClassPtr,"ProbeChannel");
			bDoCollisionTest__Offset=GetPropertyOffset(NativeClassPtr,"bDoCollisionTest");
			bUsePawnControlRotation__Offset=GetPropertyOffset(NativeClassPtr,"bUsePawnControlRotation");
			bInheritPitch__Offset=GetPropertyOffset(NativeClassPtr,"bInheritPitch");
			bInheritYaw__Offset=GetPropertyOffset(NativeClassPtr,"bInheritYaw");
			bInheritRoll__Offset=GetPropertyOffset(NativeClassPtr,"bInheritRoll");
			bEnableCameraLag__Offset=GetPropertyOffset(NativeClassPtr,"bEnableCameraLag");
			bEnableCameraRotationLag__Offset=GetPropertyOffset(NativeClassPtr,"bEnableCameraRotationLag");
			bUseCameraLagSubstepping__Offset=GetPropertyOffset(NativeClassPtr,"bUseCameraLagSubstepping");
			bDrawDebugLagMarkers__Offset=GetPropertyOffset(NativeClassPtr,"bDrawDebugLagMarkers");
			CameraLagSpeed__Offset=GetPropertyOffset(NativeClassPtr,"CameraLagSpeed");
			CameraRotationLagSpeed__Offset=GetPropertyOffset(NativeClassPtr,"CameraRotationLagSpeed");
			CameraLagMaxTimeStep__Offset=GetPropertyOffset(NativeClassPtr,"CameraLagMaxTimeStep");
			CameraLagMaxDistance__Offset=GetPropertyOffset(NativeClassPtr,"CameraLagMaxDistance");
			
		}
		
	}
	
}
#endif
#endif
