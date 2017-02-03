#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>-> will be exported to EngineDecalClasses.h</summary>
	public partial class USceneCaptureComponent
	{
		static readonly int HiddenActors__Offset;
		/// <summary>The actors to hide in the scene capture.</summary>
		public TObjectArray<AActor>  HiddenActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HiddenActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HiddenActors__Offset, false);}
			
		}
		
		static readonly int ShowOnlyActors__Offset;
		/// <summary>The only actors to be rendered by this scene capture, if present.</summary>
		public TObjectArray<AActor>  ShowOnlyActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ShowOnlyActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ShowOnlyActors__Offset, false);}
			
		}
		
		static readonly int bCaptureEveryFrame__Offset;
		/// <summary>Whether to update the capture's contents every frame.  If disabled, the component will render once on load and then only when moved.</summary>
		public bool bCaptureEveryFrame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCaptureEveryFrame__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCaptureEveryFrame__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bCaptureOnMovement__Offset;
		/// <summary>Whether to update the capture's contents on movement.  Disable if you are going to capture manually from blueprint.</summary>
		public bool bCaptureOnMovement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCaptureOnMovement__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCaptureOnMovement__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MaxViewDistanceOverride__Offset;
		/// <summary>if > 0, sets a maximum render distance override.  Can be used to cull distant objects from a reflection if the reflecting plane is in an enclosed area like a hallway or room</summary>
		public float MaxViewDistanceOverride
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxViewDistanceOverride__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxViewDistanceOverride__Offset, false);}
			
		}
		
		static readonly int ShowFlagSettings__Offset;
		/// <summary>ShowFlags for the SceneCapture's ViewFamily, to control rendering settings for this view. Hidden but accessible through details customization</summary>
		public TStructArray<FEngineShowFlagsSetting> ShowFlagSettings
		{
			get{ CheckIsValid();return new TStructArray<FEngineShowFlagsSetting>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ShowFlagSettings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ShowFlagSettings__Offset, false);}
			
		}
		
		static USceneCaptureComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SceneCaptureComponent");
			HiddenActors__Offset=GetPropertyOffset(NativeClassPtr,"HiddenActors");
			ShowOnlyActors__Offset=GetPropertyOffset(NativeClassPtr,"ShowOnlyActors");
			bCaptureEveryFrame__Offset=GetPropertyOffset(NativeClassPtr,"bCaptureEveryFrame");
			bCaptureOnMovement__Offset=GetPropertyOffset(NativeClassPtr,"bCaptureOnMovement");
			MaxViewDistanceOverride__Offset=GetPropertyOffset(NativeClassPtr,"MaxViewDistanceOverride");
			ShowFlagSettings__Offset=GetPropertyOffset(NativeClassPtr,"ShowFlagSettings");
			
		}
		
	}
	
}
#endif
#endif
