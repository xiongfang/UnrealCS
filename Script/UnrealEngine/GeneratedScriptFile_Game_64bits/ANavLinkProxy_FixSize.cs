#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ANavLinkProxy
	{
		static readonly int PointLinks__Offset;
		public TStructArray<FNavigationLink> PointLinks
		{
			get{ CheckIsValid();return new TStructArray<FNavigationLink>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PointLinks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PointLinks__Offset, false);}
			
		}
		
		static readonly int SegmentLinks__Offset;
		public TStructArray<FNavigationSegmentLink> SegmentLinks
		{
			get{ CheckIsValid();return new TStructArray<FNavigationSegmentLink>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SegmentLinks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SegmentLinks__Offset, false);}
			
		}
		
		static readonly int SmartLinkComp__Offset;
		public UNavLinkCustomComponent SmartLinkComp
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SmartLinkComp__Offset); if (v == IntPtr.Zero)return null; UNavLinkCustomComponent retValue = new UNavLinkCustomComponent(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SmartLinkComp__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SmartLinkComp__Offset, value._this.Get()); }
			
		}
		
		static readonly int bSmartLinkIsRelevant__Offset;
		public bool bSmartLinkIsRelevant
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSmartLinkIsRelevant__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSmartLinkIsRelevant__Offset, 1,0,1,255);}
			
		}
		
		static readonly int OnSmartLinkReached__Offset;
		public FMulticastScriptDelegate OnSmartLinkReached
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnSmartLinkReached__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnSmartLinkReached__Offset, false);}
			
		}
		
		static ANavLinkProxy()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavLinkProxy");
			PointLinks__Offset=GetPropertyOffset(NativeClassPtr,"PointLinks");
			SegmentLinks__Offset=GetPropertyOffset(NativeClassPtr,"SegmentLinks");
			SmartLinkComp__Offset=GetPropertyOffset(NativeClassPtr,"SmartLinkComp");
			bSmartLinkIsRelevant__Offset=GetPropertyOffset(NativeClassPtr,"bSmartLinkIsRelevant");
			OnSmartLinkReached__Offset=GetPropertyOffset(NativeClassPtr,"OnSmartLinkReached");
			
		}
		
	}
	
}
#endif
#endif
