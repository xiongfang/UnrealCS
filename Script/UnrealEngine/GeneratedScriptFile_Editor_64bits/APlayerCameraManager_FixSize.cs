#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A PlayerCameraManager is responsible for managing the camera for a particular
	/// player. It defines the final view properties used by other systems (e.g. the renderer),
	/// meaning you can think of it as your virtual eyeball in the world. It can compute the
	/// final camera properties directly, or it can arbitrate/blend between other objects or
	/// actors that influence the camera (e.g. blending from one CameraActor to another).
	/// The PlayerCameraManagers primary external responsibility is to reliably respond to
	/// various Get*() functions, such as GetCameraViewPoint. Most everything else is
	/// implementation detail and overrideable by user projects.
	/// By default, a PlayerCameraManager maintains a "view target", which is the primary actor
	/// the camera is associated with. It can also apply various "post" effects to the final
	/// view state, such as camera animations, shakes, post-process effects or special
	/// effects such as dirt on the lens.
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Camera/
	/// </summary>
	public partial class APlayerCameraManager
	{
		static readonly int PCOwner__Offset;
		/// <summary>PlayerController that owns this Camera actor</summary>
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
		/// <summary>FOV to use by default.</summary>
		public float DefaultFOV
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultFOV__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultFOV__Offset, false);}
			
		}
		
		static readonly int DefaultOrthoWidth__Offset;
		/// <summary>The default desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
		public float DefaultOrthoWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultOrthoWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultOrthoWidth__Offset, false);}
			
		}
		
		static readonly int DefaultAspectRatio__Offset;
		/// <summary>Default aspect ratio</summary>
		public float DefaultAspectRatio
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DefaultAspectRatio__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultAspectRatio__Offset, false);}
			
		}
		
		static readonly int CameraCache__Offset;
		/// <summary>Cached camera properties.</summary>
		public FCameraCacheEntry CameraCache
		{
			get{ CheckIsValid();return (FCameraCacheEntry)Marshal.PtrToStructure(_this.Get()+CameraCache__Offset, typeof(FCameraCacheEntry));}
			
		}
		
		static readonly int LastFrameCameraCache__Offset;
		/// <summary>Cached camera properties, one frame old.</summary>
		public FCameraCacheEntry LastFrameCameraCache
		{
			get{ CheckIsValid();return (FCameraCacheEntry)Marshal.PtrToStructure(_this.Get()+LastFrameCameraCache__Offset, typeof(FCameraCacheEntry));}
			
		}
		
		static readonly int ViewTarget__Offset;
		/// <summary>Current ViewTarget</summary>
		public FTViewTarget ViewTarget
		{
			get{ CheckIsValid();return (FTViewTarget)Marshal.PtrToStructure(_this.Get()+ViewTarget__Offset, typeof(FTViewTarget));}
			
		}
		
		static readonly int PendingViewTarget__Offset;
		/// <summary>Pending view target for blending</summary>
		public FTViewTarget PendingViewTarget
		{
			get{ CheckIsValid();return (FTViewTarget)Marshal.PtrToStructure(_this.Get()+PendingViewTarget__Offset, typeof(FTViewTarget));}
			
		}
		
		static readonly int ModifierList__Offset;
		/// <summary>List of active camera modifier instances that have a chance to update the final camera POV</summary>
		public TObjectArray<UCameraModifier>  ModifierList
		{
					get{ CheckIsValid();return new TObjectArray<UCameraModifier>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ModifierList__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ModifierList__Offset, false);}
			
		}
		
		static readonly int DefaultModifiers__Offset;
		/// <summary>List of modifiers to create by default for this camera</summary>
		public TObjectArray<UClass>  DefaultModifiers
		{
					get{ CheckIsValid();return new TObjectArray<UClass>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DefaultModifiers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DefaultModifiers__Offset, false);}
			
		}
		
		static readonly int FreeCamDistance__Offset;
		/// <summary>Distance to place free camera from view target (used in certain CameraStyles)</summary>
		public float FreeCamDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FreeCamDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FreeCamDistance__Offset, false);}
			
		}
		
		static readonly int FreeCamOffset__Offset;
		/// <summary>Offset to Z free camera position (used in certain CameraStyles)</summary>
		public FVector FreeCamOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+FreeCamOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FreeCamOffset__Offset, false);}
			
		}
		
		static readonly int ViewTargetOffset__Offset;
		/// <summary>Offset to view target (used in certain CameraStyles)</summary>
		public FVector ViewTargetOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+ViewTargetOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewTargetOffset__Offset, false);}
			
		}
		
		static readonly int CameraLensEffects__Offset;
		/// <summary>CameraBlood emitter attached to this camera</summary>
		public TObjectArray<AEmitterCameraLensEffectBase>  CameraLensEffects
		{
					get{ CheckIsValid();return new TObjectArray<AEmitterCameraLensEffectBase>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CameraLensEffects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CameraLensEffects__Offset, false);}
			
		}
		
		static readonly int CachedCameraShakeMod__Offset;
		/// <summary>Cached ref to modifier for code-driven screen shakes</summary>
		public UCameraModifier_CameraShake CachedCameraShakeMod
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CachedCameraShakeMod__Offset); if (v == IntPtr.Zero)return null; UCameraModifier_CameraShake retValue = new UCameraModifier_CameraShake(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimInstPool__Offset;
		/// <summary>Internal pool of camera anim instance objects available for playing camera animations. Defines the max number of camera anims that can play simultaneously.</summary>
		public UCameraAnimInst AnimInstPool
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimInstPool__Offset); if (v == IntPtr.Zero)return null; UCameraAnimInst retValue = new UCameraAnimInst(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PostProcessBlendCache__Offset;
		/// <summary>Internal list of active post process effects. Parallel array to PostProcessBlendCacheWeights.</summary>
		public TStructArray<FPostProcessSettings> PostProcessBlendCache
		{
			get{ CheckIsValid();return new TStructArray<FPostProcessSettings>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PostProcessBlendCache__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PostProcessBlendCache__Offset, false);}
			
		}
		
		static readonly int ActiveAnims__Offset;
		/// <summary>Array of camera anim instances that are currently playing and in-use</summary>
		public TObjectArray<UCameraAnimInst>  ActiveAnims
		{
					get{ CheckIsValid();return new TObjectArray<UCameraAnimInst>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActiveAnims__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActiveAnims__Offset, false);}
			
		}
		
		static readonly int FreeAnims__Offset;
		/// <summary>Array of camera anim instances that are not playing and available to be used.</summary>
		public TObjectArray<UCameraAnimInst>  FreeAnims
		{
					get{ CheckIsValid();return new TObjectArray<UCameraAnimInst>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FreeAnims__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FreeAnims__Offset, false);}
			
		}
		
		static readonly int AnimCameraActor__Offset;
		/// <summary>Internal. Receives the output of individual camera animations.</summary>
		public ACameraActor AnimCameraActor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimCameraActor__Offset); if (v == IntPtr.Zero)return null; ACameraActor retValue = new ACameraActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bIsOrthographic__Offset;
		/// <summary>True when this camera should use an orthographic perspective instead of FOV</summary>
		public bool bIsOrthographic
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsOrthographic__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsOrthographic__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bUseClientSideCameraUpdates__Offset;
		/// <summary>True if server will use camera positions replicated from the client instead of calculating them locally.</summary>
		public bool bUseClientSideCameraUpdates
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseClientSideCameraUpdates__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseClientSideCameraUpdates__Offset, 1,0,64,64);}
			
		}
		
		static readonly int ViewPitchMin__Offset;
		/// <summary>Minimum view pitch, in degrees.</summary>
		public float ViewPitchMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ViewPitchMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewPitchMin__Offset, false);}
			
		}
		
		static readonly int ViewPitchMax__Offset;
		/// <summary>Maximum view pitch, in degrees.</summary>
		public float ViewPitchMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ViewPitchMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewPitchMax__Offset, false);}
			
		}
		
		static readonly int ViewYawMin__Offset;
		/// <summary>Minimum view yaw, in degrees.</summary>
		public float ViewYawMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ViewYawMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewYawMin__Offset, false);}
			
		}
		
		static readonly int ViewYawMax__Offset;
		/// <summary>Maximum view yaw, in degrees.</summary>
		public float ViewYawMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ViewYawMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewYawMax__Offset, false);}
			
		}
		
		static readonly int ViewRollMin__Offset;
		/// <summary>Minimum view roll, in degrees.</summary>
		public float ViewRollMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ViewRollMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ViewRollMin__Offset, false);}
			
		}
		
		static readonly int ViewRollMax__Offset;
		/// <summary>Maximum view roll, in degrees.</summary>
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
