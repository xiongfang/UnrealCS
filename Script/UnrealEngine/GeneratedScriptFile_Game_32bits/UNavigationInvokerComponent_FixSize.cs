#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavigationInvokerComponent
	{
		static readonly int TileGenerationRadius__Offset;
		public float TileGenerationRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TileGenerationRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TileGenerationRadius__Offset, false);}
			
		}
		
		static readonly int TileRemovalRadius__Offset;
		public float TileRemovalRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TileRemovalRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TileRemovalRadius__Offset, false);}
			
		}
		
		static UNavigationInvokerComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavigationInvokerComponent");
			TileGenerationRadius__Offset=GetPropertyOffset(NativeClassPtr,"TileGenerationRadius");
			TileRemovalRadius__Offset=GetPropertyOffset(NativeClassPtr,"TileRemovalRadius");
			
		}
		
	}
	
}
#endif
#endif
