#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ULevelStreaming
	{
		static readonly int PackageName__Offset;
		public FName PackageName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+PackageName__Offset, typeof(FName));}
			
		}
		
		static readonly int PackageNameToLoad__Offset;
		public FName PackageNameToLoad
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+PackageNameToLoad__Offset, typeof(FName));}
			
		}
		
		static readonly int LODPackageNames__Offset;
		public TStructArray<FName> LODPackageNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODPackageNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODPackageNames__Offset, false);}
			
		}
		
		static readonly int LevelTransform__Offset;
		public FTransform LevelTransform
		{
			get{ CheckIsValid();return (FTransform)Marshal.PtrToStructure(_this.Get()+LevelTransform__Offset, typeof(FTransform));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelTransform__Offset, false);}
			
		}
		
		static readonly int bShouldBeVisibleInEditor__Offset;
		public bool bShouldBeVisibleInEditor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldBeVisibleInEditor__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bLocked__Offset;
		public bool bLocked
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLocked__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bShouldBeLoaded__Offset;
		public bool bShouldBeLoaded
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldBeLoaded__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bShouldBeVisible__Offset;
		public bool bShouldBeVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldBeVisible__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bIsStatic__Offset;
		public bool bIsStatic
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsStatic__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIsStatic__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bShouldBlockOnLoad__Offset;
		public bool bShouldBlockOnLoad
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldBlockOnLoad__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int LevelLODIndex__Offset;
		public int LevelLODIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LevelLODIndex__Offset, typeof(int));}
			
		}
		
		static readonly int bDisableDistanceStreaming__Offset;
		public bool bDisableDistanceStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableDistanceStreaming__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bDrawOnLevelStatusMap__Offset;
		public bool bDrawOnLevelStatusMap
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDrawOnLevelStatusMap__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDrawOnLevelStatusMap__Offset, 1,0,4,4);}
			
		}
		
		static readonly int DrawColor__Offset;
		public FColor DrawColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+DrawColor__Offset, typeof(FColor));}
			
		}
		
		static readonly int LevelColor__Offset;
		public FLinearColor LevelColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+LevelColor__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LevelColor__Offset, false);}
			
		}
		
		static readonly int EditorStreamingVolumes__Offset;
		public TObjectArray<ALevelStreamingVolume>  EditorStreamingVolumes
		{
					get{ CheckIsValid();return new TObjectArray<ALevelStreamingVolume>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EditorStreamingVolumes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EditorStreamingVolumes__Offset, false);}
			
		}
		
		static readonly int MinTimeBetweenVolumeUnloadRequests__Offset;
		public float MinTimeBetweenVolumeUnloadRequests
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinTimeBetweenVolumeUnloadRequests__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinTimeBetweenVolumeUnloadRequests__Offset, false);}
			
		}
		
		static readonly int Keywords__Offset;
		public TStructArray<FString> Keywords
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Keywords__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Keywords__Offset, false);}
			
		}
		
		static readonly int OnLevelLoaded__Offset;
		public FMulticastScriptDelegate OnLevelLoaded
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnLevelLoaded__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnLevelLoaded__Offset, false);}
			
		}
		
		static readonly int OnLevelUnloaded__Offset;
		public FMulticastScriptDelegate OnLevelUnloaded
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnLevelUnloaded__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnLevelUnloaded__Offset, false);}
			
		}
		
		static readonly int OnLevelShown__Offset;
		public FMulticastScriptDelegate OnLevelShown
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnLevelShown__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnLevelShown__Offset, false);}
			
		}
		
		static readonly int OnLevelHidden__Offset;
		public FMulticastScriptDelegate OnLevelHidden
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnLevelHidden__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnLevelHidden__Offset, false);}
			
		}
		
		static readonly int LoadedLevel__Offset;
		public ULevel LoadedLevel
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LoadedLevel__Offset); if (v == IntPtr.Zero)return null; ULevel retValue = new ULevel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PendingUnloadLevel__Offset;
		public ULevel PendingUnloadLevel
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PendingUnloadLevel__Offset); if (v == IntPtr.Zero)return null; ULevel retValue = new ULevel(); retValue._this = v; return retValue; }
			
		}
		
		static ULevelStreaming()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LevelStreaming");
			PackageName__Offset=GetPropertyOffset(NativeClassPtr,"PackageName");
			PackageNameToLoad__Offset=GetPropertyOffset(NativeClassPtr,"PackageNameToLoad");
			LODPackageNames__Offset=GetPropertyOffset(NativeClassPtr,"LODPackageNames");
			LevelTransform__Offset=GetPropertyOffset(NativeClassPtr,"LevelTransform");
			bShouldBeVisibleInEditor__Offset=GetPropertyOffset(NativeClassPtr,"bShouldBeVisibleInEditor");
			bLocked__Offset=GetPropertyOffset(NativeClassPtr,"bLocked");
			bShouldBeLoaded__Offset=GetPropertyOffset(NativeClassPtr,"bShouldBeLoaded");
			bShouldBeVisible__Offset=GetPropertyOffset(NativeClassPtr,"bShouldBeVisible");
			bIsStatic__Offset=GetPropertyOffset(NativeClassPtr,"bIsStatic");
			bShouldBlockOnLoad__Offset=GetPropertyOffset(NativeClassPtr,"bShouldBlockOnLoad");
			LevelLODIndex__Offset=GetPropertyOffset(NativeClassPtr,"LevelLODIndex");
			bDisableDistanceStreaming__Offset=GetPropertyOffset(NativeClassPtr,"bDisableDistanceStreaming");
			bDrawOnLevelStatusMap__Offset=GetPropertyOffset(NativeClassPtr,"bDrawOnLevelStatusMap");
			DrawColor__Offset=GetPropertyOffset(NativeClassPtr,"DrawColor");
			LevelColor__Offset=GetPropertyOffset(NativeClassPtr,"LevelColor");
			EditorStreamingVolumes__Offset=GetPropertyOffset(NativeClassPtr,"EditorStreamingVolumes");
			MinTimeBetweenVolumeUnloadRequests__Offset=GetPropertyOffset(NativeClassPtr,"MinTimeBetweenVolumeUnloadRequests");
			Keywords__Offset=GetPropertyOffset(NativeClassPtr,"Keywords");
			OnLevelLoaded__Offset=GetPropertyOffset(NativeClassPtr,"OnLevelLoaded");
			OnLevelUnloaded__Offset=GetPropertyOffset(NativeClassPtr,"OnLevelUnloaded");
			OnLevelShown__Offset=GetPropertyOffset(NativeClassPtr,"OnLevelShown");
			OnLevelHidden__Offset=GetPropertyOffset(NativeClassPtr,"OnLevelHidden");
			LoadedLevel__Offset=GetPropertyOffset(NativeClassPtr,"LoadedLevel");
			PendingUnloadLevel__Offset=GetPropertyOffset(NativeClassPtr,"PendingUnloadLevel");
			
		}
		
	}
	
}
#endif
#endif
