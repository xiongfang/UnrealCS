#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavigationPath
	{
		static readonly int PathUpdatedNotifier__Offset;
		public FMulticastScriptDelegate PathUpdatedNotifier
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+PathUpdatedNotifier__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PathUpdatedNotifier__Offset, false);}
			
		}
		
		static readonly int PathPoints__Offset;
		public TStructArray<FVector> PathPoints
		{
			get{ CheckIsValid();return new TStructArray<FVector>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PathPoints__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PathPoints__Offset, false);}
			
		}
		
		static readonly int RecalculateOnInvalidation__Offset;
		public ENavigationOptionFlag RecalculateOnInvalidation
		{
			get{ CheckIsValid();return (ENavigationOptionFlag)Marshal.PtrToStructure(_this.Get()+RecalculateOnInvalidation__Offset, typeof(ENavigationOptionFlag));}
			
		}
		
		static UNavigationPath()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavigationPath");
			PathUpdatedNotifier__Offset=GetPropertyOffset(NativeClassPtr,"PathUpdatedNotifier");
			PathPoints__Offset=GetPropertyOffset(NativeClassPtr,"PathPoints");
			RecalculateOnInvalidation__Offset=GetPropertyOffset(NativeClassPtr,"RecalculateOnInvalidation");
			
		}
		
	}
	
}
#endif
#endif
