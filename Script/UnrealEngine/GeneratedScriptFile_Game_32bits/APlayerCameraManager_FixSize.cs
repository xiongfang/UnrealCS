#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class APlayerCameraManager
	{
		static readonly int PCOwner__Offset;
		public APlayerController PCOwner
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PCOwner__Offset); if (v == IntPtr.Zero)return null; APlayerController retValue = new APlayerController(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int TransformComponent__Offset;
		public USceneComponent TransformComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TransformComponent__Offset); if (v == IntPtr.Zero)return null; USceneComponent retValue = new USceneComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + TransformComponent__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + TransformComponent__Offset, value._this.Get()); }
			
		}
		
		static readonly int DefaultFOV__Offset;
		public float DefaultFOV
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultFOV__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultFOV__Offset, false);}
			
		}
		
		static readonly int DefaultOrthoWidth__Offset;
		public float DefaultOrthoWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultOrthoWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultOrthoWidth__Offset, false);}
			
		}
		
		static readonly int DefaultAspectRatio__Offset;
		public float DefaultAspectRatio
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultAspectRatio__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultAspectRatio__Offset, false);}
			
		}
		
		static readonly int CameraCache__Offset;
		public FCameraCacheEntry CameraCache
		{
			get{ CheckIsValid();return (FCameraCacheEntry)Marshal.PtrToStructure(_this.Get()+CameraCache__Offset, typeof(FCameraCacheEntry));}
			
		}
		
		static readonly int LastFrameCameraCache__Offset;
		public FCameraCacheEntry LastFrameCameraCache
		{
			get{ CheckIsValid();return (FCameraCacheEntry)Marshal.PtrToStructure(_this.Get()+LastFrameCameraCache__Offset, typeof(FCameraCacheEntry));}
			
		}
		
		static readonly int ViewTarget__Offset;
		public FTViewTarget ViewTarget
		{
			get{ CheckIsValid();return (FTViewTarget)Marshal.PtrToStructure(_this.Get()+ViewTarget__Offset, typeof(FTViewTarget));}
			
		}
		
		static readonly int PendingViewTarget__Offset;
		public FTViewTarget PendingViewTarget
		{
			get{ CheckIsValid();return (FTViewTarget)Marshal.PtrToStructure(_this.Get()+PendingViewTarget__Offset, typeof(FTViewTarget));}
			
		}
		
		static readonly int ModifierList__Offset;
		public TObjectArray<UCameraModifier>  ModifierList
		{
					get{ CheckIsValid();return new TObjectArray<UCameraModifier>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ModifierList__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ModifierList__Offset, false);}
			
		}
		
		static readonly int DefaultModifiers__Offset;
		public TObjectArray<UClass>  DefaultModifiers
		{
					get{ CheckIsValid();return new TObjectArray<UClass>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DefaultModifiers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DefaultModifiers__Offset, false);}
			
		}
		
		static readonly int FreeCamDistance__Offset;
		public float FreeCamDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FreeCamDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FreeCamDistance__Offset, false);}
			
		}
		
		static readonly int FreeCamOffset__Offset;
		public FVector FreeCamOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+FreeCamOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FreeCamOffset__Offset, false);}
			
		}
		
		static readonly int ViewTargetOffset__Offset;
		public FVector ViewTargetOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ViewTargetOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewTargetOffset__Offset, false);}
			
		}
		
		static readonly int CameraLensEffects__Offset;
		public TObjectArray<AEmitterCameraLensEffectBase>  CameraLensEffects
		{
					get{ CheckIsValid();return new TObjectArray<AEmitterCameraLensEffectBase>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CameraLensEffects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CameraLensEffects__Offset, false);}
			
		}
		
		static readonly int CachedCameraShakeMod__Offset;
		public UCameraModifier_CameraShake CachedCameraShakeMod
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CachedCameraShakeMod__Offset); if (v == IntPtr.Zero)return null; UCameraModifier_CameraShake retValue = new UCameraModifier_CameraShake(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimInstPool__Offset;
		public UCameraAnimInst AnimInstPool
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimInstPool__Offset); if (v == IntPtr.Zero)return null; UCameraAnimInst retValue = new UCameraAnimInst(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PostProcessBlendCache__Offset;
		public TStructArray<FPostProcessSettings> PostProcessBlendCache
		{
			get{ CheckIsValid();return new TStructArray<FPostProcessSettings>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PostProcessBlendCache__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PostProcessBlendCache__Offset, false);}
			
		}
		
		static readonly int ActiveAnims__Offset;
		public TObjectArray<UCameraAnimInst>  ActiveAnims
		{
					get{ CheckIsValid();return new TObjectArray<UCameraAnimInst>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActiveAnims__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActiveAnims__Offset, false);}
			
		}
		
		static readonly int FreeAnims__Offset;
		public TObjectArray<UCameraAnimInst>  FreeAnims
		{
					get{ CheckIsValid();return new TObjectArray<UCameraAnimInst>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FreeAnims__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FreeAnims__Offset, false);}
			
		}
		
		static readonly int AnimCameraActor__Offset;
		public ACameraActor AnimCameraActor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimCameraActor__Offset); if (v == IntPtr.Zero)return null; ACameraActor retValue = new ACameraActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bIsOrthographic__Offset;
		public bool bIsOrthographic
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsOrthographic__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsOrthographic__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUseClientSideCameraUpdates__Offset;
		public bool bUseClientSideCameraUpdates
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseClientSideCameraUpdates__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseClientSideCameraUpdates__Offset, 1,0,64,64);}
			
		}
		
		static readonly int ViewPitchMin__Offset;
		public float ViewPitchMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ViewPitchMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewPitchMin__Offset, false);}
			
		}
		
		static readonly int ViewPitchMax__Offset;
		public float ViewPitchMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ViewPitchMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewPitchMax__Offset, false);}
			
		}
		
		static readonly int ViewYawMin__Offset;
		public float ViewYawMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ViewYawMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewYawMin__Offset, false);}
			
		}
		
		static readonly int ViewYawMax__Offset;
		public float ViewYawMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ViewYawMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewYawMax__Offset, false);}
			
		}
		
		static readonly int ViewRollMin__Offset;
		public float ViewRollMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ViewRollMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewRollMin__Offset, false);}
			
		}
		
		static readonly int ViewRollMax__Offset;
		public float ViewRollMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ViewRollMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewRollMax__Offset, false);}
			
		}
		
		static APlayerCameraManager()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlayerCameraManager");
			PCOwner__Offset=GetPropertyOffset(NativeClassPtr,"PCOwner");
			TransformComponent__Offset=GetPropertyOffset(NativeClassPtr,"TransformComponent");
			DefaultFOV__Offset=GetPropertyOffset(NativeClassPtr,"DefaultFOV");
			DefaultOrthoWidth__Offset=GetPropertyOffset(NativeClassPtr,"DefaultOrthoWidth");
			DefaultAspectRatio__Offset=GetPropertyOffset(NativeClassPtr,"DefaultAspectRatio");
			CameraCache__Offset=GetPropertyOffset(NativeClassPtr,"CameraCache");
			LastFrameCameraCache__Offset=GetPropertyOffset(NativeClassPtr,"LastFrameCameraCache");
			ViewTarget__Offset=GetPropertyOffset(NativeClassPtr,"ViewTarget");
			PendingViewTarget__Offset=GetPropertyOffset(NativeClassPtr,"PendingViewTarget");
			ModifierList__Offset=GetPropertyOffset(NativeClassPtr,"ModifierList");
			DefaultModifiers__Offset=GetPropertyOffset(NativeClassPtr,"DefaultModifiers");
			FreeCamDistance__Offset=GetPropertyOffset(NativeClassPtr,"FreeCamDistance");
			FreeCamOffset__Offset=GetPropertyOffset(NativeClassPtr,"FreeCamOffset");
			ViewTargetOffset__Offset=GetPropertyOffset(NativeClassPtr,"ViewTargetOffset");
			CameraLensEffects__Offset=GetPropertyOffset(NativeClassPtr,"CameraLensEffects");
			CachedCameraShakeMod__Offset=GetPropertyOffset(NativeClassPtr,"CachedCameraShakeMod");
			AnimInstPool__Offset=GetPropertyOffset(NativeClassPtr,"AnimInstPool");
			PostProcessBlendCache__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessBlendCache");
			ActiveAnims__Offset=GetPropertyOffset(NativeClassPtr,"ActiveAnims");
			FreeAnims__Offset=GetPropertyOffset(NativeClassPtr,"FreeAnims");
			AnimCameraActor__Offset=GetPropertyOffset(NativeClassPtr,"AnimCameraActor");
			bIsOrthographic__Offset=GetPropertyOffset(NativeClassPtr,"bIsOrthographic");
			bUseClientSideCameraUpdates__Offset=GetPropertyOffset(NativeClassPtr,"bUseClientSideCameraUpdates");
			ViewPitchMin__Offset=GetPropertyOffset(NativeClassPtr,"ViewPitchMin");
			ViewPitchMax__Offset=GetPropertyOffset(NativeClassPtr,"ViewPitchMax");
			ViewYawMin__Offset=GetPropertyOffset(NativeClassPtr,"ViewYawMin");
			ViewYawMax__Offset=GetPropertyOffset(NativeClassPtr,"ViewYawMax");
			ViewRollMin__Offset=GetPropertyOffset(NativeClassPtr,"ViewRollMin");
			ViewRollMax__Offset=GetPropertyOffset(NativeClassPtr,"ViewRollMax");
			
		}
		
	}
	
}
#endif
#endif
