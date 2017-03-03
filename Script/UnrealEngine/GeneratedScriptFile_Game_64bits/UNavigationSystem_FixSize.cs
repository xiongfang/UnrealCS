#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavigationSystem
	{
		static readonly int MainNavData__Offset;
		public ANavigationData MainNavData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MainNavData__Offset); if (v == IntPtr.Zero)return null; ANavigationData retValue = new ANavigationData(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AbstractNavData__Offset;
		public ANavigationData AbstractNavData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AbstractNavData__Offset); if (v == IntPtr.Zero)return null; ANavigationData retValue = new ANavigationData(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bAutoCreateNavigationData__Offset;
		public bool bAutoCreateNavigationData
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoCreateNavigationData__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoCreateNavigationData__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bAllowClientSideNavigation__Offset;
		public bool bAllowClientSideNavigation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowClientSideNavigation__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowClientSideNavigation__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bSupportRebuilding__Offset;
		public bool bSupportRebuilding
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSupportRebuilding__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bInitialBuildingLocked__Offset;
		public bool bInitialBuildingLocked
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInitialBuildingLocked__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bInitialBuildingLocked__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bSkipAgentHeightCheckWhenPickingNavData__Offset;
		public bool bSkipAgentHeightCheckWhenPickingNavData
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSkipAgentHeightCheckWhenPickingNavData__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSkipAgentHeightCheckWhenPickingNavData__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bGenerateNavigationOnlyAroundNavigationInvokers__Offset;
		public bool bGenerateNavigationOnlyAroundNavigationInvokers
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateNavigationOnlyAroundNavigationInvokers__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateNavigationOnlyAroundNavigationInvokers__Offset, 1,0,1,1);}
			
		}
		
		static readonly int ActiveTilesUpdateInterval__Offset;
		public float ActiveTilesUpdateInterval
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ActiveTilesUpdateInterval__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ActiveTilesUpdateInterval__Offset, false);}
			
		}
		
		static readonly int SupportedAgents__Offset;
		public TStructArray<FNavDataConfig> SupportedAgents
		{
			get{ CheckIsValid();return new TStructArray<FNavDataConfig>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SupportedAgents__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SupportedAgents__Offset, false);}
			
		}
		
		static readonly int DirtyAreasUpdateFreq__Offset;
		public float DirtyAreasUpdateFreq
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DirtyAreasUpdateFreq__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DirtyAreasUpdateFreq__Offset, false);}
			
		}
		
		static readonly int NavDataSet__Offset;
		public TObjectArray<ANavigationData>  NavDataSet
		{
					get{ CheckIsValid();return new TObjectArray<ANavigationData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+NavDataSet__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+NavDataSet__Offset, false);}
			
		}
		
		static readonly int NavDataRegistrationQueue__Offset;
		public TObjectArray<ANavigationData>  NavDataRegistrationQueue
		{
					get{ CheckIsValid();return new TObjectArray<ANavigationData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+NavDataRegistrationQueue__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+NavDataRegistrationQueue__Offset, false);}
			
		}
		
		static readonly int OnNavDataRegisteredEvent__Offset;
		public FMulticastScriptDelegate OnNavDataRegisteredEvent
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnNavDataRegisteredEvent__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnNavDataRegisteredEvent__Offset, false);}
			
		}
		
		static readonly int OnNavigationGenerationFinishedDelegate__Offset;
		public FMulticastScriptDelegate OnNavigationGenerationFinishedDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnNavigationGenerationFinishedDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnNavigationGenerationFinishedDelegate__Offset, false);}
			
		}
		
		static UNavigationSystem()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavigationSystem");
			MainNavData__Offset=GetPropertyOffset(NativeClassPtr,"MainNavData");
			AbstractNavData__Offset=GetPropertyOffset(NativeClassPtr,"AbstractNavData");
			bAutoCreateNavigationData__Offset=GetPropertyOffset(NativeClassPtr,"bAutoCreateNavigationData");
			bAllowClientSideNavigation__Offset=GetPropertyOffset(NativeClassPtr,"bAllowClientSideNavigation");
			bSupportRebuilding__Offset=GetPropertyOffset(NativeClassPtr,"bSupportRebuilding");
			bInitialBuildingLocked__Offset=GetPropertyOffset(NativeClassPtr,"bInitialBuildingLocked");
			bSkipAgentHeightCheckWhenPickingNavData__Offset=GetPropertyOffset(NativeClassPtr,"bSkipAgentHeightCheckWhenPickingNavData");
			bGenerateNavigationOnlyAroundNavigationInvokers__Offset=GetPropertyOffset(NativeClassPtr,"bGenerateNavigationOnlyAroundNavigationInvokers");
			ActiveTilesUpdateInterval__Offset=GetPropertyOffset(NativeClassPtr,"ActiveTilesUpdateInterval");
			SupportedAgents__Offset=GetPropertyOffset(NativeClassPtr,"SupportedAgents");
			DirtyAreasUpdateFreq__Offset=GetPropertyOffset(NativeClassPtr,"DirtyAreasUpdateFreq");
			NavDataSet__Offset=GetPropertyOffset(NativeClassPtr,"NavDataSet");
			NavDataRegistrationQueue__Offset=GetPropertyOffset(NativeClassPtr,"NavDataRegistrationQueue");
			OnNavDataRegisteredEvent__Offset=GetPropertyOffset(NativeClassPtr,"OnNavDataRegisteredEvent");
			OnNavigationGenerationFinishedDelegate__Offset=GetPropertyOffset(NativeClassPtr,"OnNavigationGenerationFinishedDelegate");
			
		}
		
	}
	
}
#endif
#endif
