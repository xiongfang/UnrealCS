#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ANavigationData
	{
		static readonly int RenderingComp__Offset;
		public UPrimitiveComponent RenderingComp
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RenderingComp__Offset); if (v == IntPtr.Zero)return null; UPrimitiveComponent retValue = new UPrimitiveComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NavDataConfig__Offset;
		public FNavDataConfig NavDataConfig
		{
			get{ CheckIsValid();return (FNavDataConfig)Marshal.PtrToStructure(_this.Get()+NavDataConfig__Offset, typeof(FNavDataConfig));}
			
		}
		
		static readonly int bEnableDrawing__Offset;
		public bool bEnableDrawing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableDrawing__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableDrawing__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bForceRebuildOnLoad__Offset;
		public bool bForceRebuildOnLoad
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceRebuildOnLoad__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceRebuildOnLoad__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bCanBeMainNavData__Offset;
		public bool bCanBeMainNavData
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanBeMainNavData__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanBeMainNavData__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bCanSpawnOnRebuild__Offset;
		public bool bCanSpawnOnRebuild
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanSpawnOnRebuild__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanSpawnOnRebuild__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bRebuildAtRuntime__Offset;
		public bool bRebuildAtRuntime
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRebuildAtRuntime__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int ObservedPathsTickInterval__Offset;
		public float ObservedPathsTickInterval
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ObservedPathsTickInterval__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ObservedPathsTickInterval__Offset, false);}
			
		}
		
		static readonly int DataVersion__Offset;
		public uint DataVersion
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+DataVersion__Offset, typeof(uint));}
			
		}
		
		static readonly int SupportedAreas__Offset;
		public TStructArray<FSupportedAreaData> SupportedAreas
		{
			get{ CheckIsValid();return new TStructArray<FSupportedAreaData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SupportedAreas__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SupportedAreas__Offset, false);}
			
		}
		
		static ANavigationData()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavigationData");
			RenderingComp__Offset=GetPropertyOffset(NativeClassPtr,"RenderingComp");
			NavDataConfig__Offset=GetPropertyOffset(NativeClassPtr,"NavDataConfig");
			bEnableDrawing__Offset=GetPropertyOffset(NativeClassPtr,"bEnableDrawing");
			bForceRebuildOnLoad__Offset=GetPropertyOffset(NativeClassPtr,"bForceRebuildOnLoad");
			bCanBeMainNavData__Offset=GetPropertyOffset(NativeClassPtr,"bCanBeMainNavData");
			bCanSpawnOnRebuild__Offset=GetPropertyOffset(NativeClassPtr,"bCanSpawnOnRebuild");
			bRebuildAtRuntime__Offset=GetPropertyOffset(NativeClassPtr,"bRebuildAtRuntime");
			ObservedPathsTickInterval__Offset=GetPropertyOffset(NativeClassPtr,"ObservedPathsTickInterval");
			DataVersion__Offset=GetPropertyOffset(NativeClassPtr,"DataVersion");
			SupportedAreas__Offset=GetPropertyOffset(NativeClassPtr,"SupportedAreas");
			
		}
		
	}
	
}
#endif
#endif
