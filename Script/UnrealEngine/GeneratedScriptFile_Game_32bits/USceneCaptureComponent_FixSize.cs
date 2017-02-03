#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USceneCaptureComponent
	{
		static readonly int HiddenActors__Offset;
		public TObjectArray<AActor>  HiddenActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HiddenActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HiddenActors__Offset, false);}
			
		}
		
		static readonly int ShowOnlyActors__Offset;
		public TObjectArray<AActor>  ShowOnlyActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ShowOnlyActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ShowOnlyActors__Offset, false);}
			
		}
		
		static readonly int bCaptureEveryFrame__Offset;
		public bool bCaptureEveryFrame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCaptureEveryFrame__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCaptureEveryFrame__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bCaptureOnMovement__Offset;
		public bool bCaptureOnMovement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCaptureOnMovement__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCaptureOnMovement__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MaxViewDistanceOverride__Offset;
		public float MaxViewDistanceOverride
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxViewDistanceOverride__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxViewDistanceOverride__Offset, false);}
			
		}
		
		static readonly int ShowFlagSettings__Offset;
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
