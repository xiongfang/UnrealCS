#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ACameraActor
	{
		static readonly int AutoActivateForPlayer__Offset;
		public EAutoReceiveInput AutoActivateForPlayer
		{
			get{ CheckIsValid();return (EAutoReceiveInput)Marshal.PtrToStructure(_this.Get()+AutoActivateForPlayer__Offset, typeof(EAutoReceiveInput));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AutoActivateForPlayer__Offset, false);}
			
		}
		
		static readonly int CameraComponent__Offset;
		public UCameraComponent CameraComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CameraComponent__Offset); if (v == IntPtr.Zero)return null; UCameraComponent retValue = new UCameraComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CameraComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CameraComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int SceneComponent__Offset;
		public USceneComponent SceneComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SceneComponent__Offset); if (v == IntPtr.Zero)return null; USceneComponent retValue = new USceneComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SceneComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SceneComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int bConstrainAspectRatio__Offset;
		public bool bConstrainAspectRatio
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bConstrainAspectRatio__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int AspectRatio__Offset;
		public float AspectRatio
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AspectRatio__Offset, typeof(float));}
			
		}
		
		static readonly int FOVAngle__Offset;
		public float FOVAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FOVAngle__Offset, typeof(float));}
			
		}
		
		static readonly int PostProcessBlendWeight__Offset;
		public float PostProcessBlendWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PostProcessBlendWeight__Offset, typeof(float));}
			
		}
		
		static readonly int PostProcessSettings__Offset;
		public FPostProcessSettings PostProcessSettings
		{
			get{ CheckIsValid();return (FPostProcessSettings)Marshal.PtrToStructure(_this.Get()+PostProcessSettings__Offset, typeof(FPostProcessSettings));}
			
		}
		
		static ACameraActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CameraActor");
			AutoActivateForPlayer__Offset=GetPropertyOffset(NativeClassPtr,"AutoActivateForPlayer");
			CameraComponent__Offset=GetPropertyOffset(NativeClassPtr,"CameraComponent");
			SceneComponent__Offset=GetPropertyOffset(NativeClassPtr,"SceneComponent");
			bConstrainAspectRatio__Offset=GetPropertyOffset(NativeClassPtr,"bConstrainAspectRatio");
			AspectRatio__Offset=GetPropertyOffset(NativeClassPtr,"AspectRatio");
			FOVAngle__Offset=GetPropertyOffset(NativeClassPtr,"FOVAngle");
			PostProcessBlendWeight__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessBlendWeight");
			PostProcessSettings__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessSettings");
			
		}
		
	}
	
}
#endif
#endif
