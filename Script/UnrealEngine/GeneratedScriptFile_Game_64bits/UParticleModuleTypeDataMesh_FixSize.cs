#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataMesh
	{
		static readonly int Mesh__Offset;
		public UStaticMesh Mesh
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Mesh__Offset); if (v == IntPtr.Zero)return null; UStaticMesh retValue = new UStaticMesh(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Mesh__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Mesh__Offset, value._this.Get()); }
			
		}
		
		static readonly int CastShadows__Offset;
		public bool CastShadows
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CastShadows__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int DoCollisions__Offset;
		public bool DoCollisions
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), DoCollisions__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int MeshAlignment__Offset;
		public EMeshScreenAlignment MeshAlignment
		{
			get{ CheckIsValid();return (EMeshScreenAlignment)Marshal.PtrToStructure(_this.Get()+MeshAlignment__Offset, typeof(EMeshScreenAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MeshAlignment__Offset, false);}
			
		}
		
		static readonly int bOverrideMaterial__Offset;
		public bool bOverrideMaterial
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideMaterial__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideMaterial__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOverrideDefaultMotionBlurSettings__Offset;
		public bool bOverrideDefaultMotionBlurSettings
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideDefaultMotionBlurSettings__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideDefaultMotionBlurSettings__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bEnableMotionBlur__Offset;
		public bool bEnableMotionBlur
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableMotionBlur__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableMotionBlur__Offset, 1,0,4,4);}
			
		}
		
		static readonly int Pitch__Offset;
		public float Pitch
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Pitch__Offset, typeof(float));}
			
		}
		
		static readonly int Roll__Offset;
		public float Roll
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Roll__Offset, typeof(float));}
			
		}
		
		static readonly int Yaw__Offset;
		public float Yaw
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Yaw__Offset, typeof(float));}
			
		}
		
		static readonly int RollPitchYawRange__Offset;
		public FRawDistributionVector RollPitchYawRange
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+RollPitchYawRange__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RollPitchYawRange__Offset, false);}
			
		}
		
		static readonly int AxisLockOption__Offset;
		public EParticleAxisLock AxisLockOption
		{
			get{ CheckIsValid();return (EParticleAxisLock)Marshal.PtrToStructure(_this.Get()+AxisLockOption__Offset, typeof(EParticleAxisLock));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AxisLockOption__Offset, false);}
			
		}
		
		static readonly int bCameraFacing__Offset;
		public bool bCameraFacing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCameraFacing__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCameraFacing__Offset, 1,0,1,1);}
			
		}
		
		static readonly int CameraFacingUpAxisOption__Offset;
		public EMeshCameraFacingUpAxis CameraFacingUpAxisOption
		{
			get{ CheckIsValid();return (EMeshCameraFacingUpAxis)Marshal.PtrToStructure(_this.Get()+CameraFacingUpAxisOption__Offset, typeof(EMeshCameraFacingUpAxis));}
			
		}
		
		static readonly int CameraFacingOption__Offset;
		public EMeshCameraFacingOptions CameraFacingOption
		{
			get{ CheckIsValid();return (EMeshCameraFacingOptions)Marshal.PtrToStructure(_this.Get()+CameraFacingOption__Offset, typeof(EMeshCameraFacingOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CameraFacingOption__Offset, false);}
			
		}
		
		static readonly int bApplyParticleRotationAsSpin__Offset;
		public bool bApplyParticleRotationAsSpin
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bApplyParticleRotationAsSpin__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bApplyParticleRotationAsSpin__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bFaceCameraDirectionRatherThanPosition__Offset;
		public bool bFaceCameraDirectionRatherThanPosition
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFaceCameraDirectionRatherThanPosition__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFaceCameraDirectionRatherThanPosition__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bCollisionsConsiderPartilceSize__Offset;
		public bool bCollisionsConsiderPartilceSize
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollisionsConsiderPartilceSize__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCollisionsConsiderPartilceSize__Offset, 1,0,4,4);}
			
		}
		
		static UParticleModuleTypeDataMesh()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleTypeDataMesh");
			Mesh__Offset=GetPropertyOffset(NativeClassPtr,"Mesh");
			CastShadows__Offset=GetPropertyOffset(NativeClassPtr,"CastShadows");
			DoCollisions__Offset=GetPropertyOffset(NativeClassPtr,"DoCollisions");
			MeshAlignment__Offset=GetPropertyOffset(NativeClassPtr,"MeshAlignment");
			bOverrideMaterial__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideMaterial");
			bOverrideDefaultMotionBlurSettings__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideDefaultMotionBlurSettings");
			bEnableMotionBlur__Offset=GetPropertyOffset(NativeClassPtr,"bEnableMotionBlur");
			Pitch__Offset=GetPropertyOffset(NativeClassPtr,"Pitch");
			Roll__Offset=GetPropertyOffset(NativeClassPtr,"Roll");
			Yaw__Offset=GetPropertyOffset(NativeClassPtr,"Yaw");
			RollPitchYawRange__Offset=GetPropertyOffset(NativeClassPtr,"RollPitchYawRange");
			AxisLockOption__Offset=GetPropertyOffset(NativeClassPtr,"AxisLockOption");
			bCameraFacing__Offset=GetPropertyOffset(NativeClassPtr,"bCameraFacing");
			CameraFacingUpAxisOption__Offset=GetPropertyOffset(NativeClassPtr,"CameraFacingUpAxisOption");
			CameraFacingOption__Offset=GetPropertyOffset(NativeClassPtr,"CameraFacingOption");
			bApplyParticleRotationAsSpin__Offset=GetPropertyOffset(NativeClassPtr,"bApplyParticleRotationAsSpin");
			bFaceCameraDirectionRatherThanPosition__Offset=GetPropertyOffset(NativeClassPtr,"bFaceCameraDirectionRatherThanPosition");
			bCollisionsConsiderPartilceSize__Offset=GetPropertyOffset(NativeClassPtr,"bCollisionsConsiderPartilceSize");
			
		}
		
	}
	
}
#endif
#endif
